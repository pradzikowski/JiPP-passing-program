using System;
using System.IO;
using System.Linq;

namespace Zaliczenie_JiPP
{
	public abstract class DirectoryProvider
	{
		String homeDirectory;
		String currentDirectory;

		String[] directoryView;

		public DirectoryProvider (string homeDirecotry)
		{
			this.homeDirectory 	  = homeDirecotry;
			this.currentDirectory = homeDirecotry;
		}

		public String CurrentDirectory{
			get{
				return currentDirectory;
			}
		}

		public String[] DirectoryView{
			get{
				return directoryView;
			}
		}

		public void refreshDirectoryView() {
			directoryView = Directory.GetFileSystemEntries (currentDirectory);
		}

		private void goToParent() {
			currentDirectory = Directory.GetParent (currentDirectory).FullName;
		}

		public void goTo(int id) {
			
		}
	}
}

