//
// TestForChallenge.cs
//
// Author:
//       rzaitov <>
//
// Copyright (c) 2014 rzaitov
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System.Diagnostics;
using System.IO;
using System.Threading;
using MonoDevelop.Core;
using MonoDevelop.Ide.Commands;
using NUnit.Framework;
using MonoDevelop.Refactoring;

namespace UserInterfaceTests
{
	public class TestForChallenge : UITestBase
	{
		[Test]
		public void TestGenericsNameSpace()
		{
			string projectName = "ProjectWithGenerics";
			string projectCategory = "C#";
			string projectKind = "Console Project";

			FilePath projectDirectory = Util.CreateTmpDir (projectName);
			FilePath srcDir = projectDirectory.Combine (projectName, projectName);

			Ide.CreateProject (projectName, projectCategory, projectKind, projectDirectory);

			Ide.OpenFile (srcDir.Combine("Program.cs"));

			Session.SelectActiveWidget ();
			Session.ExecuteCommand (TextEditorCommands.DocumentStart);
			Session.ExecuteCommand (TextEditorCommands.SelectionMoveToDocumentEnd);
			Session.TypeText (@"using System;

namespace ConsoleProject
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            List<string> s = new List<string> () {""one"", ""two"", ""three""};
            Console.WriteLine (""Hello Xamarin!"");
        }
    }
}");

			Ide.AssertBuild (errors: 1, warnings: 0);

			Session.ExecuteCommand (TextEditorCommands.DocumentStart);
			for (int n = 0; n < 8; n++)
				Session.ExecuteCommand (TextEditorCommands.LineDown);

			Session.ExecuteCommand (TextEditorCommands.MoveNextWord);
			Thread.Sleep (1000);

			Session.ExecuteCommand (RefactoryCommands.QuickFix);
			Thread.Sleep (1000);

			Session.PressKey (Gdk.Key.Return);
			Ide.AssertBuild (errors: 0, warnings: 1);

			var exe = srcDir.Combine ("bin", "Debug", projectName).ChangeExtension("exe");
			AssertExeHasOutput (exe, "Hello Xamarin!");

			Ide.CloseAll ();
		}
	}
}

