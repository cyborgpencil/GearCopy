
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearCopy.ViewModels
{
    public class SimpleCopyViewModel : BindableBase
    {
        private List<string> FileNames;
        

        private string _sourceTextBox;
        public string SourceTextBox
        {
            get { return _sourceTextBox; }
            set { SetProperty(ref _sourceTextBox, value); }
        }

        private DelegateCommand _browseSourceCommand;
        public DelegateCommand BrowseSourceCommand
        {
            get { return _browseSourceCommand; }
            set { SetProperty(ref _browseSourceCommand, value); }
        }

        private string _selectedFiles;
        public string SelectedFiles
        {
            get { return _selectedFiles; }
            set { SetProperty(ref _selectedFiles, value); }
        }

        private string _targetTextBox;
        public string TargetTextBox
        {
            get { return _targetTextBox; }
            set { SetProperty(ref _targetTextBox, value); }
        }
        private DelegateCommand _targetCommand;
        public DelegateCommand TargetCommand
        {
            get { return _targetCommand; }
            set { SetProperty(ref _targetCommand, value); }
        }

        public SimpleCopyViewModel()
        {
            BrowseSourceCommand = new DelegateCommand(BrowseSource);
            SelectedFiles = "0";
            TargetCommand = new DelegateCommand(Target);
        }

        private void BrowseSource()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileNames = new List<string>(dlg.FileNames.ToList());
                SelectedFiles = FileNames.Count.ToString();
                SourceTextBox = string.Concat(dlg.FileNames);
            }
        }

        private void Target()
        {
            FolderBrowserDialog flg = new FolderBrowserDialog();
            flg.Description = "Test Description";

            if(flg.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
