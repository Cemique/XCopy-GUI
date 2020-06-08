using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace XCopyGuiProject
{
    public partial class Form1 : Form
    {

        public Form1(string sourceFolder=null, string destinationFolder=null)
        {
            InitializeComponent();

            #region Gradient Background
            LinearGradientBrush gradBrush = new LinearGradientBrush(
                new Point(0, 0), 
                new Point(this.Width, this.Height),
                Color.Transparent, 
                Color.FromArgb(30, Color.RoyalBlue));
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(gradBrush, new Rectangle(0, 0, this.Width,this.Height));
            this.BackgroundImage = bmp;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            #endregion

            #region Populate Form
            if (sourceFolder!=null)
                this.textBox_Source.Text = sourceFolder;
            if (destinationFolder != null)
                this.textBox_Destination.Text = destinationFolder;

            this.comboBox1.SelectedIndex = 2;


            DirectoryInfo ex = new DirectoryInfo(Application.LocalUserAppDataPath + Path.DirectorySeparatorChar + "Saved Excludes");
            if(ex.Exists)
                foreach (FileInfo info in ex.GetFiles("*.exd", SearchOption.TopDirectoryOnly)) 
                    this.comboBox2.Items.Add(Path.GetFileNameWithoutExtension(info.FullName));

            #endregion

            //FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //On Click Menu->New; prompt leaving unsaved business
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You have unsaved business. Are you sure you want to leave it?", "XCopy GUI - New", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                resetForm();
        }

        //Empty the form
        private void resetForm() {
            //TODO
        }

        //On Click Source Button
        private void button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = this.textBox_Source.Text;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                this.textBox_Source.Text = dialog.FileName;
        }

        //On Click Destination Button
        private void button2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = this.textBox_Destination.Text;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                this.textBox_Destination.Text = dialog.FileName;
        }

        //On Click Exclude Info Picture
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            showInfoMessage("Exclude paths from being copied (One path exception per line)." + "\n" +
                "If any part of the full path of a file/directory matches any of the path exceptions," +
                " it will be excluded from being copied. For example if 'Exclude' contains:" + "\n\n" +
                @"\pathA\" + "\n" +
                @"pathB" + "\n" +
                @"\pathC" + "\n" +
                @"pathD\" + "\n" +
                @".ext" + "\n\n" +
                "the following files and directories will be excluded:" + "\n\n" +
                @"C:\...\pathA\" + "\n" +
                @"C:\...\xpathB1\" + "\n" +
                @"C:\...\filepathB.txt" + "\n" +
                @"C:\...\pathC1\" + "\n" +
                @"C:\...\pathCx.txt" + "\n" +
                @"C:\...\xpathD\" + "\n"+
                @"C:\...\afile.ext" + "\n\n"
                );
        }

        //On Click Any Info Picture
        private void infoIcon_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox) 
                showInfoMessage(this.toolTip1.GetToolTip((PictureBox)sender));
        }

        //On checkBox_Modified_After change, if checked disable checkBox_Modified_Lately
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Enabled = this.checkBox_Modified_After.Checked;
            this.label13.Enabled = !this.checkBox_Modified_After.Checked;
            this.checkBox_Modified_Lately.Enabled = !this.checkBox_Modified_After.Checked;
        }

        //On checkBox_Modified_Lately change, if checked disable checkBox_Modified_After
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            this.label4.Enabled = !this.checkBox_Modified_Lately.Checked;
            this.checkBox_Modified_After.Enabled = !this.checkBox_Modified_Lately.Checked;
        }

        //On checkBox_Archive_Only_Clear change, if checked disable checkBox_Archive_Only
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            this.label8.Enabled = !this.checkBox_Archive_Only_Clear.Checked;
            this.checkBox_Archive_Only.Enabled = !this.checkBox_Archive_Only_Clear.Checked;
            this.checkBox_Archive_Only.Checked = false;
        }

        //On checkBox_Permissions_Audits change, if checked disable checkBox_Permissions
        private void checkBox_Permissions_Audits_CheckedChanged(object sender, EventArgs e)
        {
            this.label12.Enabled = !this.checkBox_Permissions_Audits.Checked;
            this.checkBox_Permissions.Enabled = !this.checkBox_Permissions_Audits.Checked;
            this.checkBox_Permissions.Checked = this.checkBox_Permissions_Audits.Checked;
        }

        //On Click Start
        private void button3_Click(object sender, EventArgs e)
        {
            DirectoryInfo source;
            try
            {
                source = new DirectoryInfo(this.textBox_Source.Text);
            }
            catch (Exception)
            {
                showErrorMessage("Invalid source path");
                return;
            }
            DirectoryInfo dest;
            try
            {
                dest = new DirectoryInfo(this.textBox_Destination.Text);
            }
            catch (Exception)
            {
                showErrorMessage("Invalid destination path");
                return;
            }
            //if source and destination is equal show error
            if (source.FullName.TrimEnd('\\').Equals(dest.FullName.TrimEnd('\\'))) {
                showErrorMessage("Source & destination paths may not be the same");
                return;
            }
            //if destination is not empty, prompt user as file override possible
            if (dest.Exists && (dest.GetFiles().Length>0 || dest.GetDirectories().Length > 0) ) {
                if (MessageBox.Show("Destination is not empty!\nFile override possible, continue?", "XCopy GUI - Warning"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Warning) != DialogResult.Yes)
                    return;
            }

            //if (MessageBox.Show("Copying...\n\nFrom:\n" + source.FullName + "\n\nTo:\n" + dest.FullName, "Are you sure?"
            //    , MessageBoxButtons.YesNo
            //    , MessageBoxIcon.Warning) != DialogResult.Yes)
            //    return;

            xcopy(source, dest);
        }

        private void showErrorMessage(string error) {
            MessageBox.Show(error, "XCopy GUI - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void showInfoMessage(string info) {
            MessageBox.Show(info, "XCopy GUI - Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void log(string log) {
            string logFile = Application.LocalUserAppDataPath + Path.DirectorySeparatorChar + "logs";
            if (!File.Exists(logFile)) 
                Directory.CreateDirectory(Path.GetDirectoryName(logFile));
            File.AppendAllText(logFile, Environment.NewLine + log);
        }

        //always-on arguments
        private string[] fixedArguments = {"/i", "/y"};

        //starting the copy process
        private void xcopy(DirectoryInfo source, DirectoryInfo dest)
        {
            List<string> args = new List<string>();
            args.AddRange(fixedArguments);

            //adding arguments needed for the scope
            switch (this.comboBox1.SelectedIndex) {
                case 1:
                    args.Add("/s");
                    break;
                case 2:
                    args.Add("/e");
                    break;
                case 3:
                    args.Add("/t /s");
                    break;
                case 4:
                    args.Add("/t /e");
                    break;
            }

            #region arguments of checkBoxes
            if (this.checkBox_Modified_After.Checked)
                args.Add("/d:"+ this.dateTimePicker1.Value.ToString("MM-dd-yyyy"));
            else if(this.checkBox_Modified_Lately.Checked)
                args.Add("/d");
            if(this.checkBox_Matched_Files_Only.Checked)
                args.Add("/u");
            if(this.checkBox_Rewrite_Read_only.Checked)
                args.Add("/k");
            if (this.checkBox_Hidden_Files.Checked)
                args.Add("/h");
            if (this.checkBox_Archive_Only.Checked)
                args.Add("/a");
            else if (this.checkBox_Archive_Only_Clear.Checked)
                args.Add("/m");
            if(this.checkBox_8_3_Names.Checked)
                args.Add("/n");
            if (this.checkBox_Permissions.Checked)
                args.Add("/o");
            else if(this.checkBox_Permissions_Audits.Checked)
                args.Add("/x");
            #endregion

            //exclude argument (if any path present in textBox_Exclude)
            //a text file containing textbox's content is created in the path %AppData%\exclude dummy.txt
            //and the argument /exclude:%AppData%\exclude dummy.txt will be added
            //note that the path may not contain any space in it, so we have to convert it's name to SFN file convention
            //if that can't happen, we are unable to add the exclude, so we show an error.
            if (textBox_Exclude.Text.Trim().Length > 0) {
                string excludeFile = (Application.LocalUserAppDataPath + Path.DirectorySeparatorChar + "exclude dummy.txt").Trim();
                File.WriteAllText(excludeFile, textBox_Exclude.Text);
                if (excludeFile.Contains(" ")) {
                    string excludeFileShort="";
                    if (!isShortNameEnabled() || !isShortPathValid(excludeFile, excludeFileShort = Utils.longToShortPath(excludeFile)) ) { 
                        showErrorMessage("Unable to read the exclude file. Probably you have disabled 8.3 file naming");
                        log("#ShortNameError isShortNameEnabled:" + isShortNameEnabled()+ " excludeFileShort:" + excludeFileShort);
                        return;
                    }
                    args.Add("/exclude:" + excludeFileShort);
                } else {
                    args.Add("/exclude:"+ excludeFile);
                }
            }

            //The form containing progressbar to show when copying
            //after ShowDialog() the thread waits for the form to respond (close)
            //So we'll add a listener to the process (proc.Exited) so that when it ends, we close the form.
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Owner = this;
            Action showLoading = () => loadingForm.ShowDialog();
            Action hideLoading = () => {
                //Invoke is to prevent thread error
                loadingForm.Invoke((Action) ( () => {
                    loadingForm.Close();
                    loadingForm.Dispose();
                }));
            };

            string command = String.Format(" /C xcopy \"{0}\" \"{1}\" {2} ", source.FullName, dest.FullName, String.Join(" ", args.ToArray()));
            log("#command " + command);

            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", command);
            procStartInfo.RedirectStandardOutput = true;    //so we can get callbacks in OutputDataReceived
            procStartInfo.RedirectStandardError = true;     //so we can get callbacks in ErrorDataReceived
            procStartInfo.UseShellExecute = false;          //donno what it does:)
            procStartInfo.CreateNoWindow = true;            //so the user does not get the black terminal window
            
            //ProgressBar and exit coded

            Process proc = new Process();
            proc.EnableRaisingEvents = true;                //so we can get callbacks in Exited
            proc.StartInfo = procStartInfo;

            proc.OutputDataReceived += (theProc, dataArg) => {
                if (!String.IsNullOrEmpty(dataArg.Data))
                {
                    //Console.WriteLine("out: " + dataArg.Data);
                }
            };
            proc.ErrorDataReceived += (theProc, dataArg) => {
                if (!String.IsNullOrEmpty(dataArg.Data))
                {
                    showErrorMessage("err: "+ dataArg.Data);
                    log("#error " + dataArg.Data);
                }
            };

            proc.Exited += (theProc, dataArg) => {
                hideLoading();
                string message;

                //Error code descriptions are from:
                //https://docs.microsoft.com/en-us/windows-server/administration/windows-commands/xcopy#remarks
                switch (proc.ExitCode) {
                    case 0:
                        message = "Files were copied without error.";
                        break;
                    case 1:
                        message = "No files were found to copy.";
                        break;
                    case 2:
                        message = "The user pressed CTRL+C to terminate xcopy.";
                        break;
                    case 4:
                        message = "Initialization error occurred.There is not enough memory or disk space"+
                            ", or you entered an invalid drive name or invalid syntax on the command line.";
                        break;
                    case 5:
                        message = "Disk write error occurred.";
                        break;
                    default:
                        message = "";
                        break;
                }
                showInfoMessage("Finished!\n"+ message);
            };

            //Start the process after progress form shown
            loadingForm.Shown += (s, a) => {
                proc.Start();
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();
                //proc.WaitForExit();
                //endLoading();
            };

            showLoading();

        }

        //Check if SFN enabled by creating a long path and trying to convert it to SFN
        private static bool isShortNameEnabled() {
            try
            {
                string dummyFile = Application.LocalUserAppDataPath + Path.DirectorySeparatorChar + "dummy folder" + Path.DirectorySeparatorChar + "dummy file.txt";
                if (!File.Exists(dummyFile)) { 
                    Directory.CreateDirectory(Path.GetDirectoryName(dummyFile));
                    File.WriteAllText(dummyFile, "dummy");
                    if (!File.Exists(dummyFile))
                        return false;
                }

                string sfn = Utils.longToShortPath(dummyFile);
                if(!isShortPathValid(dummyFile, sfn))
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        //Validate short path using space check. Does not prove validation but enough 
        //for our business as our problem is with spaces (there may be other problems, 
        //hope to find with users' feedbacks)
        private static bool isShortPathValid(string longPath, string shortPath) {
            return shortPath.Length != 0 && !shortPath.Contains(" ");
        }

        //On Click save exception. Show an inputbox so the user chooses a name then save it in %AppData%\Saving exceptions
        private void button_save_exceptions_Click(object sender, EventArgs e)
        {
            DirectoryInfo excludeDir = new DirectoryInfo(Application.LocalUserAppDataPath + Path.DirectorySeparatorChar + "Saved Excludes");
            int index = 1;
            while (new FileInfo(
                Application.LocalUserAppDataPath + Path.DirectorySeparatorChar + "Saved Excludes" +
                    Path.DirectorySeparatorChar + "exceptions_" + index + ".exd"
                    ).Exists)
                index++;
            string name;
            while (true) {
                try
                {
                    name = Microsoft.VisualBasic.Interaction.InputBox("Choose a name...", "Saving exceptions", "exceptions_" + index);
                    if (name == null || (name = name.Trim()).Length == 0)
                        return;

                    FileInfo info = new FileInfo(
                            Application.LocalUserAppDataPath + Path.DirectorySeparatorChar + "Saved Excludes" +
                                Path.DirectorySeparatorChar + name + ".exd"
                                );
                    if (info.Exists) { 
                        showErrorMessage("Duplicate! Choose a differet name");
                        continue;
                    }else if (name.IndexOfAny(new char[] { '\\', '/', ':', '*', '?', '"', '<', '>', '|' }) != -1) { 
                        showErrorMessage("Illegal character (\\/:*?\"<>|)");
                        continue;
                    }

                    Directory.CreateDirectory(Path.GetDirectoryName(info.FullName));
                    using (info.Create()) { }
                    break;
                }
                catch (Exception)
                {
                    showErrorMessage("Illegal! Choose a differet name");
                }
            }

            this.comboBox2.Items.Add(name);

            File.WriteAllText(Application.LocalUserAppDataPath + Path.DirectorySeparatorChar + "Saved Excludes" +
                    Path.DirectorySeparatorChar + name + ".exd", this.textBox_Exclude.Text);
        }

        //On textBox_Exclude text changed
        private void textBox_Exclude_TextChanged(object sender, EventArgs e)
        {
            this.button_save_exceptions.Enabled = this.textBox_Exclude.Text.Trim().Length > 0;
        }

        //On saved exceptions combobox item changed
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.button_add_exceptions.Enabled = this.comboBox2.SelectedIndex != -1;
        }

        //Add selected file exceptions to the textBox_Exclude
        private void button_add_exceptions_Click(object sender, EventArgs e)
        {
            this.textBox_Exclude.AppendText((this.textBox_Exclude.Text.Trim().Length>0 ? Environment.NewLine : "")+
            File.ReadAllText(Application.LocalUserAppDataPath + Path.DirectorySeparatorChar + "Saved Excludes" +
                    Path.DirectorySeparatorChar + this.comboBox2.Text+ ".exd")
                );
            //this.comboBox2.Items.RemoveAt(this.comboBox2.SelectedIndex);
        }

    }

    class Utils {

        //SFN converter
        public static string longToShortPath(string path)
        {
            StringBuilder stringBuilder = new StringBuilder(255);
            GetShortPathName(path, stringBuilder, stringBuilder.Capacity);
            return stringBuilder.ToString().Trim();
        }

        //SFN converter
        public static string shortToLongPath(string path)
        {
            StringBuilder stringBuilder = new StringBuilder(255);
            GetLongPathName(path, stringBuilder, stringBuilder.Capacity);
            return stringBuilder.ToString().Trim();
        }

        //Given a short path, it fills the longPath buffer with the long path
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern int GetLongPathName(
                    [MarshalAs(UnmanagedType.LPTStr)] string path,
                    [MarshalAs(UnmanagedType.LPTStr)] StringBuilder longPath,
                    int longPathLength
        );


        //Given a long path, it fills the shortPath buffer with the short path
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern int GetShortPathName(
                    [MarshalAs(UnmanagedType.LPTStr)] string path,
                    [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath,
                    int shortPathLength
        );

        //Run a delayed task
        public static void delayedTask(int delayMillis, Action action)
        {
            Timer tmrOnce = new Timer();
            tmrOnce.Tick += (sender, args) => {
                tmrOnce.Dispose();
                action();
            };
            tmrOnce.Interval = delayMillis;
            tmrOnce.Start();
        }

    }

}
