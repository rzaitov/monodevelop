﻿//
// IOImpl.cs
//
// Author:
//       Mike Krüger <mkrueger@xamarin.com>
//
// Copyright (c) 2014 Xamarin Inc. (http://xamarin.com)
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
using System;
using System.IO;
using Mono.TextEditor.Utils;
using System.Text;
using System.Linq;
using Jurassic.Library;
using Jurassic;

namespace TypeScriptBinding.Hosting
{
	class IOImpl : ObjectInstance, IIO, IEnvironment
	{
		string executingFilePath;

		public string ExecutingFilePath {
			get {
				return executingFilePath;
			}
			set {
				executingFilePath = value;
			}
		}

		public StringWriter ErrorWriter {
			get;
			private set;
		}

		public StringWriter OutWriter {
			get;
			private set;
		}

		public void ResetIO ()
		{
			stderr = new TextWriterImpl (Engine, ErrorWriter = new StringWriter ());
			stdout = new TextWriterImpl (Engine, OutWriter = new StringWriter ());
		}

		public IOImpl (ScriptEngine engine, string executingFilePath) : base (engine)
		{
			this.executingFilePath = executingFilePath;
			ResetIO ();
			this.PopulateFunctions ();
		}

		[JSProperty]
		public ObjectInstance Environment {
			get {
				return this;
			}
		}

		#region IIO implementation

		[JSFunction]
		public FileInformation readFile (string path, int codepage)
		{
			return FileInformation.Read (Engine, path, codepage);
		}

		[JSFunction]
		public void writeFile (string path, string contents, bool writeByteOrderMark)
		{
			TextFileUtility.WriteText (path, contents, Encoding.UTF8, writeByteOrderMark); 
		}

		[JSFunction]
		public void deleteFile (string path)
		{
			File.Delete (path); 
		}

		[JSFunction]
		public string[] dir (string path, object re, object options)
		{
			return Directory.GetFiles (path);
		}

		[JSFunction]
		public bool fileExists (string path)
		{
			return File.Exists (path);
		}

		[JSFunction]
		public bool directoryExists (string path)
		{
			return Directory.Exists (path);
		}

		[JSFunction]
		public void createDirectory (string path)
		{
			Directory.CreateDirectory (path);
		}

		[JSFunction]
		public string resolvePath (string path)
		{
			return System.IO.Path.IsPathRooted (path) ? path : Path.Combine (getExecutingFilePath (), path);
		}

		[JSFunction]
		public string dirName (string path)
		{
			return Path.GetDirectoryName(path);
		}

		[JSFunction]
		public IResolvedFile findFile (string rootPath, string partialFilePath)
		{
			Console.WriteLine ("FIND: " + partialFilePath);
			var file = Directory.GetFiles (rootPath, partialFilePath, SearchOption.AllDirectories).FirstOrDefault (); 
			if (file == null)
				return null;
			return new ResolvedFileImpl (Engine, file);
		}

		[JSFunction]
		public void print (string str)
		{
			Console.Write (str);
		}

		[JSFunction]
		public void printLine (string str)
		{
			Console.WriteLine (str);
		}

		//[JSFunction]
		public IFileWatcher watchFile (string fileName, Action<string> callback)
		{
			return null;
		}

		[JSFunction]
		public void run (string source, string filename)
		{
			Console.WriteLine ("RUN");
		}

		[JSFunction]
		public string getExecutingFilePath ()
		{
			return executingFilePath;
		}

		[JSFunction]
		public void quit (int exitCode)
		{
			// TODO
		}

		[JSProperty]
		public ArrayInstance arguments {
			get;
			set;
		}

		[JSProperty]
		public ObjectInstance stderr {
			get;
			set;
		}

		[JSProperty]
		public ObjectInstance stdout {
			get;
			set;
		}
		#endregion

		#region IEnvironment implementation
		[JSFunction]
		public bool supportsCodePage ()
		{
			return true;
		}

		[JSFunction]
		public string[] listFiles (string path, object re, object options)
		{
			return null;
		}

		[JSFunction]
		public string currentDirectory ()
		{
			return this.executingFilePath;

		}

		[JSProperty]
		public ObjectInstance standardOut {
			get {
				return stdout;
			}
		}

		[JSProperty]
		public string newLine {
			get {
				return System.Environment.NewLine;
			}
		}
		#endregion
	}
}