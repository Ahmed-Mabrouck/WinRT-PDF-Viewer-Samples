# WinRT-PDF-Viewer-Samples
A PDF Viewer Control for Windows Runtime Platform [WinRT] for Windows 8.1 Universal Applications (Mainly a Solution for Windows Phone 8.1 Issue Missing PDF Reader).

It can be used for both Windows 8.1 & Windows Phone 8.1 for a unified UX/UI.

It is built over PDF.js developed by Mozilla.


# How Can I Use It ?
You can explore these samples (Ordinary & MVVM) or Follow These Simple Steps:

01. Install WinRT PDF Viewer Nuget Package (can find the Nuget package here: https://www.nuget.org/packages/WinRtPdfViewer/).

02. In your XAML page (Inside <Page ..> Tag), Add reference to the namespace containing the PdfViewer control like this:

	```XAML
	<Page
	xmlns:c="using:WinRT.Controls"
	>
	```

03. Add PdfViewer control to your page like this:

	```XAML
	    <c:PdfViewer />
	```

04. You can load your pdf inside your control using 1 of 2 ways:

..1. Using PickPdfFile() method.
01. Give your control a codebehind name (x:Name).
```XAML
<c:PdfViewer x:Name="testPdf"/>
```
		02.In you code behind class, you can call this method
		```C#
	    testPdf.PickPdfFile();
		```
		03.A FileOpenPicker dialog will appear, the picked PDF file will be loaded inside PdfViewer control directly.
		
	01.Using Source property.
		01.Copy your PDF file to your Project [AppX (ms-appx)].
		
		02.Set PdfViewer control Source property to the AppX URI of your file.
		```XAML
		<c:PdfViewer Source="ms-appx:///sample.pdf"/>
		```
		Or Bind it to a Uri property.
		```XAML
		<c:PdfViewer Source="{Binding PdfFile}"/>
		```
		*Note: for initial files inside your project (AppX Files), make sure that the file is copied to output directory by following the coming steps
		01.Right click on your file and then select Properties.
		02.In Build Action property, choose Content.
		03.In Copy to Outpu Directory, choose Copy If Newer.
