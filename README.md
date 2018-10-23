# ConversationHelperBot
Conversation helper bot for Telegram



## Current Version  - 10/16/18

### [Designer]
:hammer: fixed bug with enabled buttons "Grid", "Guides", "Automatic Guides", "Delete Horizontal Guides" and "Delete Vertical Guides" when active page is DialogPage  
:hammer: fixed bug with enabled buttons in group Report->Bands when active page is DialogPage  
:hammer: fixed bug with System.NullReferenceException when trying to copy DialogPage  

### [Engine]
:bug: fixed bug with System.ArgumentOutOfRangeException in MSChartObject.DeleteSeries(int index) method  
:bug: fixes bug with "optional hyphen" in rich text parser  
> optional hyphen is a feature of MS Word which is a text formatting hint.  


### [Exports]
:hammer: fixed text display in pdf export on linux systems, when text starts with a tab  

## Version 2018.4

### [.Net Core]
:heavy_plus_sign: added FastReport.Data.OracleODPCore package to Nuget repository (https://www.nuget.org/profiles/FastReports)  
:hammer: fixed a bug where sometimes whitespace characters at the end of a line were moved to a new line  
:hammer: fixed names of data types for .Net Core  
:hammer: fixed a bug  with corrupted "new line" symbols in online designer  
:hammer: fixed a bug where Core exports were wrong  
:hammer: fixed a bug with https-saving in Online Designer for FastReprot.Web.Core  
:bug: removed api of dialogues from the version for .Net Core  

### [Common]
:heavy_plus_sign: added tests for FR Open Source  

### [Demos]
:heavy_plus_sign: added a demo project, how to use FastReport in the CentOS docker container  
:hammer: fixed too long message showing "Printing page N" in FastReport.NET Demo  

### [Designer]
:heavy_plus_sign: added saving last active tab of the designer options window  
:heavy_plus_sign: added ability to resize band by dragging its top, in this case objects move in band  
:heavy_plus_sign: now in View Data window shown numbers of rows on page  
:heavy_plus_sign: added ability to copy report pages in designer  
:heavy_plus_sign: added "Text file (*.txt)" and "All files(*.*)" filters in CSV connection  
:heavy_plus_sign: added Hyperlink.OpenLinkInNewTab property  
:hammer: fixed bug with saving sql query by Finish button  
:hammer: fixed bug when format controls stay enabled after deleting object  
:hammer: fixed bug with incorrect addition of a new object if property of the selected object has changed  
:hammer: fixed bug with System.OverflowException in DesignerControl when loading report containing page with unlimited width  
:hammer: fixed bug with visibility of DataBand properties Left, Top and Width  
:hammer: fixed bug with equal field names in CSV connection when field names are stored in first line of file  
:hammer: fixed bug with System.ArgumentException when file name contains point "." in CSV connection  
:hammer: fixed bug with System.NullReferenceException after closing Start Page tab in MDI designer  
:hammer: fixed bug with incorrect movement of objects when mouse moves too fast if band is resizing by dragging its top  
:hammer: fixed a bug with file extension in Save As dialog, when report is converted from a file that is not FastReport .NET file  
:hammer: fixed bug with saving file to wrong folder in Save As dialog  
:hammer: fixed rare bug when View Data window is increased and not all rows are shown but there is enough space  
:hammer: fixed bug with entering Polish symbol "ą" (Right Alt + "A") in text editor  
:hammer: fixed bug with lost focus of Event Editor after Preview  
:heavy_minus_sign: buttons in View Data window are disabled when window less than needed for one row  
:heavy_minus_sign: now buttons in Data Tree become disabled when the tree loses focus  

### [Engine]
:heavy_plus_sign: added the ability to disable hotkeys in designer and preview  
:heavy_plus_sign: added property FastReport.Utils.Config.PreparedCompressed (default value: true) for enable or disable the compression in files with prepared reports (fpx)  
:heavy_plus_sign: added possibility to access totals, parameters and variables without case sensitivity  
:heavy_plus_sign: added a new experimental feature to improve the work with memory  
> we are constantly trying to improve performance and memory usage of FastReport.Net, at the moment we added a new experimental property Config.IsStringOptimization, which allows us to use strings from the string pool when loading very large fpx reports. To enable this feature, simply change the IsStringOptimization value to true. While the property is experimental the changing this property is only available manually from code. Especially this property will be interesting to users who use at least 1 000 000 objects in the report.  

:hammer: fixed bug with position of SubreportObject on page with unlimited width  
:hammer: fixed bug with "SVGObject.Grayscale = true -> SVGObject.Grayscale = false is still Grayscale"  
:hammer: fix parsing of multipage text in RichObject  
:hammer: fixed bug in MSChartObject with AutoSeries in detailed reports  
:hammer: fixed "An item with the same key has already been added" bug in AssemblyDescriptor.Compile() method  
:hammer: fixed a bug where a large amount of text in a cell leads to in an infinite generation of blank pages in the report  
> aTTENTION !!! We decreased the default value of the MaxHeight property from 5000 to 1000 for the TableRow object. You need to check your reports if you used rows in tables large then 10 inches in height!!!  

:hammer: fixed a bug of printing text objects with the property TextRenderType = HtmlParagraph  
:hammer: fixed a bug where in some cases, images when exporting to PDF were higher than needed  
:hammer: fixed a bug with the rotation of barcodes  
:hammer: fixed bug with encoding of character ";" in barcode Code128  
:hammer: fixed bug with RTF tags inside expression of RichText object  
:hammer: fix expression parser of RichObject  
:hammer: fix CR/LF translation in an expression result inside Richtext object  
:heavy_minus_sign: optimized QR Code Barcode Object rendering  
:heavy_minus_sign: now integer division by zero does not lead to generator crashing, instead of that expression containing error will be exchanged to text "DIVISION BY ZERO!"  
:heavy_minus_sign: new RTF parser - if "ConvertRichText" option is enabled, then an embedded  RTF document is splitting to report objects - TextObject, TableObject, and PictureObject  

### [Exports]
:heavy_plus_sign: added translation of RichObject text in DOCX export for Layered and Paragraph modes  
:heavy_plus_sign: added property Excel2007Export.PrintFit in Excel 2007 export (may be set in NoScaling, FitSheetOnOnePage, FitAllColumsOnOnePage, FitAllRowsOnOnePage)  
:heavy_plus_sign: added the DoNotExpandShiftReturn property to the Word2007Export user interface, allowing you to control the horizontal alignment for soft return  
:heavy_plus_sign: added a new property AsBitmap for Barcode which indicates to use a bitmap instead of vector, the default property is False, which means exporting as a vector  
:heavy_plus_sign: added property HTMLExport.EnableVectorObjects (enabled by default)  
:hammer: fixed bug with extra width documents in export in Excel 2007  
:hammer: fixed issue with Watermark transparency in PDF export  
:hammer: fixed null reference exception in ImageExport when Watermark.Text is null  
:hammer: fixed issue with exporting \ in Hyperlinks in PDF  
:hammer: fixed a bug with the export of BarcodeObject with using the Padding property when it is converted to SVG  
:hammer: fixed the export property SvgAsPicture of PDF, when the barcodes were exported as SVG and not as images  
:hammer: fixed issue with decimal separator in Persian locale  
:hammer: fixed bug with exporting pictures to Excel 2003 (BIFF8, xls)  
:hammer: fixed bug with opening export file in Excel 2007 with non-zero ParagraphOffset property  
:hammer: fixed bug with paddings in Excel 2007 export  
:hammer: fixed bug with drawing the borders of table in PDF export with properties Layout = Wrapped, FixedColumns = 1 and dynamic count of columns  
:hammer: deep refactoring of font embedding engine, added check font's rights for embedding/subsetting  
:hammer: fix font style simulation in PDF export  
:hammer: fix "Text in Curves" mode in PDF export  
:hammer: fixed bug with transparent background of picture in Excel 2007 (xlsx)  
:hammer: fixed bug with single picture in Excel 2003 (xls, BIFF8) and Excel 2007 (xlsx)  
:hammer: fixed bug with incorrect file names in HTML export with Subfolder = true  
:hammer: fixed bug with barcode incorrect position inside TableCell in PDF, HTML, SVG exports  
:hammer: fixed memory leak with using barcodes in PDF, HTML exports  
:hammer: fixed bug with "too much bold" in PDF export  
:hammer: fixed dynamic page orientation, page size and padding in MS Word 2007  
:hammer: fixed bug with export of some characters in Excel2007Export  
:hammer: fixed bug with negative width/height of picture in HTML export and WebReport  
:heavy_minus_sign: improved font packaging in pdf export, using simple ligatures (fi, tt)  
:heavy_minus_sign: increased accuracy for SVG in high resolution when exporting to PDF  
:heavy_minus_sign: the exports menu has been refactored, now the exports are grouped by category  
:heavy_minus_sign: updated export to FR3 (FastReport VCL files), added export of tables, barcodes, maps and shapes  

### [Extras]
:hammer: fixed bug with quotes in queries, that contain schema name in FastReport.Data.Postgres package; now available non-public schemas in designer  
:hammer: fixed FastReport.Data.Json package bug with Newtonsoft.Json.dll location  
:hammer: fixed bug with ActiveQueryBuilder parameters  

### [Online Designer]
:heavy_plus_sign: added property Hyperlink.OpenLinkInNewTab for opening links in new tabs  
:hammer: htmlTags replaced by TextRendererType  
:hammer: fixed bug with spaces in object name  

### [Preview]
:heavy_plus_sign: added ability to copy and delete prepared pages in preview  
:heavy_minus_sign: now Duplex will be changed in Print window if it has been changed in printer settings  

### [Resources]
:heavy_minus_sign: all resources was moved to Resources folder  

### [WebReport]
:heavy_plus_sign: added a property WebReport.XlsxPrintFitPage for enable stretching the Excel 2007 worksheet in one page on printing  
:heavy_plus_sign: added a constructor WebReport(bool inlineRegistration, bool stretched) that makes fast initialization with presets for 100% width and 100% height  
:heavy_plus_sign: added a constructor WebReport(bool inlineRegistration) that makes fast initialization of control without any previous external scripts/css loading  
:heavy_plus_sign: added a method WebReport.LoadPrepared(Stream stream) that loads a prepared report from stream  
:heavy_plus_sign: added a method WebReport.LoadPrepared(string fileName) that loads a prepared report from file  
:heavy_plus_sign: added a method WebReport.LoadFromStream(Stream stream) that loads a report from stream  
:heavy_plus_sign: added a method WebReport.LoadFromFile(string fileName) that loads a report from file  
:heavy_plus_sign: added an example Demos/C#/Web/PreparedPreview/ that demonstrates of working with prepared report in Web  
:hammer: fixed bug with rendering of barcodes in Internet Explorer 8 and older  
:hammer: fixed bug with saving report with Referenced Assemblies in Online Designer from Firefox browser  
:hammer: fixed bug with checking handlers in Web.config  

## Version 2018.3

### [.Net Core]
:heavy_plus_sign: added SVGObject  
:heavy_plus_sign: added FastReport.Data.MsSql package to Nuget repository (https://www.nuget.org/profiles/FastReports)  
:heavy_plus_sign: added FastReport.Data.MySql package to Nuget repository (https://www.nuget.org/profiles/FastReports)  
:heavy_plus_sign: added FastReport.Data.Postgres package to Nuget repository (https://www.nuget.org/profiles/FastReports)  
:heavy_plus_sign: added FastReport.Data.SQLite package to Nuget repository (https://www.nuget.org/profiles/FastReports)  
:heavy_plus_sign: added FastReport.Data.Json package to Nuget repository (https://www.nuget.org/profiles/FastReports)  
:heavy_plus_sign: added FastReport.Data.RavenDB package to Nuget repository (https://www.nuget.org/profiles/FastReports)  
:heavy_plus_sign: added FastReport.Data.Couchbase package to Nuget repository (https://www.nuget.org/profiles/FastReports)  
:heavy_plus_sign: added FastReport.Data.MongoDB package to Nuget repository (https://www.nuget.org/profiles/FastReports)  
:hammer: fixed bug with drill-downs in WebReport Core  
:hammer: fixed bug with export in Word 2007 in some cases  
:hammer: fixed bug with blank images in Excel 2007  
:heavy_minus_sign: added compatibility with macOS  

### [Demos]
:heavy_minus_sign: in the polygons demo report the stars were replaced by beautiful ones  

### [Designer]
:heavy_plus_sign: added possibility to set default script language  
:heavy_plus_sign: added columns editor in properties and in popup menu for DataBand  
:hammer: fixed bug with default script language when standalone designer run first time  
:hammer: fixed bug in View Data window when columns more that 655  
:hammer: fixed rare bug when table is not shown in View Data window  

### [Engine]
:heavy_plus_sign: now for exporting the Barcode Object is converted to vector graphics for PDF, HTML and SVG exports  
:heavy_plus_sign: added print of unlimited pages on roll printers (ReportPage.PrintOnRollPaper property)  
:heavy_plus_sign: added a new logic for converting objects before exporting, the process is automatic, this is necessary to convert some objects into vector graphics.  
:heavy_plus_sign: added a new property ParagraphFormat for formatting paragraphs in a text object only when the HtmlParagraph value is set in the TextRenderType property. This property allows you to adjust the line spacing and the first line indent.  
:hammer: fixed image size calculation for rotating SVG object  
:hammer: fixed the rendering of the subscript and superscript for the new type of the text renderer HtmlParagraph, when in some cases the size and layout of the text was incorrectly calculated.  
:hammer: fixed bug with svg objects, that contains "DOCTYPE svg PUBLIC"  
:hammer: fixed bug with [COPYNAME#] in page watermark  
:hammer: fixed TextObject property name where the word Multiply was used instead of Multiple  
:heavy_minus_sign: rewritten code of expressions substitution in RichObject  
:heavy_minus_sign: the HtmlTags property of the TextObject was marked as obsolete, a new property TextRenderType was added.  
> developer note: the HtmlTags property allowed some HTML tags to be used in the TextObject text, one of the available tags is the FONT tag, this tag is deprecated, and not all browsers adequately support it, so we added a new renderer that allows you to use some CSS styles, in the style attribute and the tag SPAN.  

:heavy_minus_sign: the new text render supports the following tags: b, i, u, strike, br, sub, sup, img, span.  
> developer note: we do not aim to make a copy of the browser in a text object, but we try to make the logic as similar as possible with limitations, the img tag only supports the src (http, https, base64), the width and the height attributes (values in pixels), tags b, i, u, strike, sub, sup and span support only the style attribute, with a minimum set of styles.  


### [Exports]
:heavy_plus_sign: added the TextObject with TextRenderType = HtmlParagraph to pdf, html, word2007 exports  
:heavy_plus_sign: added properties Word2007Export.PrintOptimized and Excel2007Export.PrintOptimized  
:heavy_plus_sign: added checkboxes "Print optimized" in dialogs Word 2007 and Excel 2007  
:heavy_plus_sign: sVGObject exports as vector graphics into PDF now  
:heavy_plus_sign: added a new tab "Vector Graphics" to export pdf, you able to set the quality of gradients, gradients interpolation and curves interpolation for SVG object and fonts in curves  
:heavy_plus_sign: added FontScale property to Excel2007Export  
:hammer: fixed bug with paragraph formatting in Word 2007 export  
:hammer: fixed bug with wrong size of "unlimited" page in Word 2007  
:hammer: fixed bug with field names in DBF export  
:hammer: fixed bug with overlapping of text labels in SVG export dialog  
:hammer: fixed bug with screen resolution in Word 2007 export  
:hammer: sVGObject exports as SVG into HTML now  
:heavy_minus_sign: export in Word 2007 in paragraph based mode saves the document without pagination  
:heavy_minus_sign: added converting to Number format for Excel2007 export  
:heavy_minus_sign: improved paragraph based export in Word 2007  
:heavy_minus_sign: reduced size of output file in Word 2007 (duplicate images are not saved)  

### [Extras]
:heavy_plus_sign: added Steema TeeChart object editor (double click on TeeChart object)  
:hammer: fixed bug with some string values when connecting data source to TeeChart object  
:hammer: removed the ability to select for properties LabelField, XValuesField and YValuesField fields from data sources to which the TeeChart object is not connected  
:heavy_minus_sign: modified ActiveQueryBuilder plug-in (https://www.activequerybuilder.com/): it provides query parameters and show database schema now  

### [Online Designer]
:heavy_plus_sign: added the ability to change the language in the tab view  
:heavy_plus_sign: all requests are sent from the same-origin  
:hammer: fixed abbreviations of some languages  

### [Preview]
:heavy_plus_sign: added possibility to disable saving prepared report in Preview (PreviewExports.Prepared element)  
:heavy_plus_sign: added SaveInitialDirectory property (Config.PreviewSettings.SaveInitialDirectory = @"C:\user\initial_directory";)  
:hammer: fixed bug when all exports should be disabled in Preview (PreviewControl.PreviewExports == PreviewExports.None) but Excel 97, ZPL and LaTeX exports are enabled  
:heavy_minus_sign: improved image caching method for SVG object  

### [Resources]
:heavy_minus_sign: updated French resources  

### [WebReport]
:heavy_plus_sign: added SVGObject to WebReport as svg image  
:heavy_plus_sign: added properties WebReport.DocxPrintOptimized and WebReport.XlsxPrintOptimized  
:hammer: fixed bug with third and more drill-downs with detailed pages  
:hammer: fixed bug with wrong URL's in drill-downs  

## Version 2018.2

### [.Net Core]
:heavy_plus_sign: added Demo packages in Nuget repository (https://www.nuget.org/profiles/FastReports)  
:hammer: fixed error with packages installation  

### [Designer]
:heavy_plus_sign: added an event indicator for objects and bands, a small triangle in the upper left corner; this feature is able to be enabled or disabled in the designer settings (disabled by default)  
:heavy_plus_sign: added a new tab of the designer's settings: "Objects appearance"  
:hammer: fixed import from rdl 2010 report template  

### [Engine]
:heavy_plus_sign: added SVGObject into main library FastReport.dll (for .Net 4 and higher, without Core compatibility now)  
:heavy_plus_sign: added compatibility with Fips Algorithm Policy (with limitations: encryption of PDF export, encryption of report)  

### [Exports]
:heavy_plus_sign: added property RichTextObject.ConvertRichText for conversion the RichText in text objects on exporting (experimental)  
:heavy_plus_sign: added paragraph based export in Word 2007 (experimental), property Word2007Export.ParagraphBased  
:hammer: fixed bug with slow export of reports with unlimited width or height  
:hammer: fixed bug with opening exported files in Excel 2007  
:hammer: fixed bug with default value Word2007Export.Wysiwyg  
:hammer: fixed bug with checkboxes in layered Word 2007  
:hammer: fixed bug with lines and shapes in layered Word 2007 export  
:hammer: fixed bug with removing the last character of each row when exporting to CSV without separator  
:hammer: fixed bug with text resources in FTP export  
:hammer: fixed bug with latin characters in interactive PDF in Chrome  
:hammer: fixed bug with large size of PDF files  
:hammer: fixed bug with transparent background of cells in Excel 2007 export  
:heavy_minus_sign: increased speed of export to CSV  
:heavy_minus_sign: increased speed of export to PDF  

### [Extras]
:heavy_plus_sign: added Steema TeeChart object plugin (\Extras\Misc\TeeChartObjectPlugin) https://www.steema.com/  
:heavy_plus_sign: added new demo \Demos\C#\PrintZPL  

### [Online Designer]
:heavy_plus_sign: added online/offline notifications  
:heavy_plus_sign: added offline working of designer with service workers  
:heavy_plus_sign: added property Editable for text objects and checkboxes  
:heavy_plus_sign: added component SimpleProgressGauge  
:heavy_plus_sign: added ability of horizontal resizing the bands  
:hammer: fixed bug with adding the components in dialog page  
:hammer: fixed bug with incorrect drawing the resize line of the band  
:hammer: fixed bug with incorrect selection of DataSource for DataBand on save a report  
:heavy_minus_sign: changed style of tooltips on moving the components  

### [WebReport]
:heavy_plus_sign: added support for editable TextObject and CheckBoxObject  
:heavy_plus_sign: added properties WebReport.DocxWysiwyg, WebReport.DocxParagraphBased  
:hammer: fixed position of loading indicator  
:hammer: fixed bug with null pointer in service javascript code  

## Version 2018.1

### [.Net Core]
:heavy_plus_sign: added WebReport for .Net Core (FastReport.Web.Core\README.md)  
:heavy_plus_sign: added support Online Designer  

### [Designer]
:heavy_plus_sign: added Gauge editors, semi-radial gauges, added gradient fill to Pointer  
:hammer: fixed bug with processing mouse event on PolyLineObject and PolygonObject toolbars  
:heavy_minus_sign: improved report generation speed with UseFileCache option  
:heavy_minus_sign: improved selection of LineObject when zoom > 100%  

### [Engine]
:heavy_plus_sign: added Editable property for TextObject and CheckBoxObject  
:hammer: fixed error when parameter with type double initialized by int value  

### [Exports]
:heavy_plus_sign: added polygons and polylines to PowerPoint export  
:heavy_plus_sign: added ShiftNonExportable property indicating that the report bands should be shifted, if page has any non-exportable bands (Exportable = false)  
:heavy_plus_sign: added PreserveAspectRatio, UseWidthAndHeight and UseViewBox properties to SVG export  
:heavy_plus_sign: added forms export for pdf export, objects with the Editable property, will be exported as an input field  
:heavy_plus_sign: added export in ZPL (Zebra printers)  
:hammer: fixed bug with ImageExport if report contain tables  
:hammer: fixed bug with ampersand in links for Excel2007Export  
:hammer: fixed bug with Word2007 export (black pages in OpenOffice)  
:hammer: fixed bug when exporting report from code with Report.MaxPages equal 1 or more  
:hammer: fixed bug with multiple export from one export class instance  
:hammer: fixed bug with SVG export to multiple files  
:hammer: width and height replaced to vievBox in svg export  

### [Extras]
:hammer: fixed bug with encoding in json connector, added DataEncoding property  

### [Online Designer]
:heavy_plus_sign: added ability to hide of preview button on building  
:heavy_plus_sign: added grouping of similar components (Gauge etc.) in tab with components  
:heavy_plus_sign: added dialog window with error text from server on saving of report  
:heavy_plus_sign: added SVGObject  
:hammer: property values of Cursor have been updated  
:hammer: fixed bug with selection of color from toolbar in IE browser  
:hammer: fixed bug with field with selection for color in Highlight editor and Border editor in IE browser  
:hammer: fixed bug with empty properties panel for TableColumn and TableRow  
:hammer: fixed bug with showing of bands in incorrect order in Chrome browser  
:heavy_minus_sign: info (i) is showing in dialog instead of popup in top corner  

### [Preview]
:heavy_plus_sign: added the ability to change of TextObject and CheckBoxObject in Preview when these objects have Editable property  
:hammer: fixed non-working search in preview  

### [WebReport]
:heavy_plus_sign: added outline (TOC) of report in WebReport  
:hammer: fixed issue when fastreport handler in 'location' tags  

## Version 2017.4

### [Core]
:heavy_plus_sign: added initial support of .Net Core (\Demos\Core\FastReportCore.MVC\readme.txt)  

### [Designer]
:heavy_plus_sign: added pagination in Data View Window  
:heavy_plus_sign: added Space to separators list in CSV connection  
:heavy_plus_sign: added possibility to open List and Label files with extensions crd, srt, inv, lab and let  
:heavy_plus_sign: added selecting previous file filter in open file dialog  
:hammer: fixed bug with deleting of bands  
:hammer: fixed bug with empty fields when connecting to CSV table  
:hammer: fixed bug with space separator when connecting to CSV table  
:hammer: fixed bug with strings without separator when connecting to CSV table  
:hammer: fixed bug when viewing business object data  
:hammer: fixed bug with null value of System.Guid instance  
:hammer: fixed bug in PageColumns class when number of positions is not equal number of columns  

### [Engine]
:heavy_plus_sign: trim property has been added for linear barcodes  
:heavy_plus_sign: tag property has been added for all components  
:heavy_plus_sign: added saving of meta data (ReportInfo.Name, ReportInfo.Author, ReportInfo.Description,  ReportInfo.Created, ReportInfo.Modified, ReportInfo.CreatorVersion) in prepared report file  
:heavy_plus_sign: added RegisterData(DataSet data, bool enableAllTables) and RegisterData(DataSet data, string name, bool enableAllTables) functions for registering DataSet and enabling all its tables  
:heavy_plus_sign: added possibility to access the Report.Dictionary without case sensitivity  
:heavy_plus_sign: added RadialGauge control  
:heavy_plus_sign: added SimpleProgressGauge control  
:hammer: fixed wrong result for n.9999 values in NumToWords functions  
:hammer: fixed bug with multi-thread preparing and using the cursors inside a report  
:hammer: fixed borders for Gauges  
:hammer: adjusted scale and pointer for SimpleGauge  

### [Exports]
:heavy_plus_sign: added export in LaTeX (without pictures, works with XeLaTex)  
:heavy_plus_sign: added converting to Percent format for Excel2007 export  
:heavy_plus_sign: added Word2007Export.RowHeight property with enum (Minimum, Exactly)  
:hammer: fixed bug with tilde in Excel2007 export  
:hammer: fixed bug with image duplicating in PDFExport  
:hammer: fixed bug with Biff8 export from prepared report  
:hammer: allowed export TextObjects with not default FontWithRatio to Excel 2007  
:hammer: fixed bug with table cells duplicates in XAML, SVG exports  
:hammer: fixed bug with barcode duplicates in PDF export  

### [Extras]
:heavy_plus_sign: added Web API self-hosted example (Demos\C#\Web\WebApiSelfHosted)  
:heavy_plus_sign: added SVGObject plugin (\Extras\Misc\SVGObjectPlugin)  
:heavy_plus_sign: added TelegramMessenger plugin (\Extras\Misc\Messaging\TelegramMessenger)  
:heavy_plus_sign: added support for MaxiCode and Intelligent Mail barcodes  
:heavy_plus_sign: added editor for hyperlink property  
:heavy_minus_sign: improved Crystal Reports converter, now works with the latest versions of Crystal  

### [Online Designer]
:heavy_plus_sign: added Highlight editor  
:heavy_plus_sign: added resizing area for the left sidebar  
:heavy_plus_sign: added MaxiCode & Intelligent Mail barcodes  
:heavy_plus_sign: added ability to call control dialogs from properties panel by clicking button in the title of subsection  
:heavy_plus_sign: switch all the customization panels at once  
:heavy_plus_sign: font editing dialog  
:heavy_plus_sign: border property editing dialog  
:heavy_plus_sign: hyperlink property editing dialog  
:heavy_plus_sign: building process changed  
:hammer: fixed bug with positioning DataHeader Band after DataBand  
:hammer: fixed bug with freezing in IE  
:heavy_minus_sign: popup restyle in the upper right corner  

### [WebReport]
:heavy_plus_sign: added property WebReport.DesignerConfig for storing custom configuration of Online Designer  
:hammer: fixed bug with WebReport object resizing  

## Version 2017.3

### [Designer]
:heavy_plus_sign: added ability of multi-line editing of Report.ReportInfo.Description and Report.ReportInfo.Tag  
:hammer: fixed bug with wrong width of different lines of border  

### [Engine]
:heavy_plus_sign: added Intelligent Mail (USPS) barcode  
:heavy_plus_sign: added support functions with optional parameters  
:heavy_plus_sign: added property Report.ReportInfo.SaveMode  
:heavy_plus_sign: added property Report.ReportInfo.Tag  
:heavy_plus_sign: added MaxiCode barcode  
:heavy_minus_sign: added thread-safe collections support for .net 4  

### [Exports]
:heavy_plus_sign: added ability to embed any file in PDF export with methods: PDFExport.AddEmbeddedXML, PDFExport.AddEmbeddedFile  
:hammer: fixed bug with black boxes in exports  
:hammer: fixed bug with padding and height of text in PDF export  
:hammer: fixed bug with bands Exportable property  
:hammer: fixed creating blank page after a table in RTF and Word2007 exports  
:hammer: fixed appearance of dates in Excel2007 export  

### [Extras]
:heavy_plus_sign: added new example for Web API \Demos\C#\Web\WebApi  
:heavy_plus_sign: added new example for working with ZUGFeRD and PDF/A-3b \Demos\C#\ZUGFeRD  
:hammer: fixed bug with relative path to JSON file in JSON connector  

### [Online Designer]
:heavy_plus_sign: added support of new property ReportInfo.Tag in Report object  
:hammer: fixed multi-level view of childs links  
:hammer: property Padding can contain only integer values  

### [WebReport]
:heavy_plus_sign: added catching of exceptions on call of WebReport.DesignerSaveCallBack  
:heavy_plus_sign: added properties WebReport.RequestHeaders, WebReport.ResponseHeaders  
:hammer: fixed TTF exceptions processing for PDFExport  
:hammer: fixed bug with lines in HTML export and WebReport  
:hammer: fixed page margins in printing from browser  

## Version 2017.2

### [Designer]
:heavy_plus_sign: added support of Right-to-Left Interface (RTL)  
:heavy_plus_sign: added a new property to MSChartObject, that allows to use several series with automatic creation  
:hammer: fixed bug when instead of creating a new data source, editing of selected data source was opening  

### [Engine]
:heavy_plus_sign: added new barcode: Pharmacode  
:heavy_plus_sign: added new option for images: Grayscale display mode  
:heavy_plus_sign: added ability to change the color of barcodes  
:heavy_plus_sign: added caching of compiled report script  
:hammer: fixed bug with losing precision in totals  
:hammer: fixed bug with enabled ReportPage.UnlimitedHeight and ReportPage.PrintOnPreviousPage  
:hammer: fixed bug with null initialization in text objects  
:hammer: fixed bug with deserialization on saving from On-line Designer  

### [Exports]
:heavy_plus_sign: added export in Excel 97-2003 (BIFF8)  
:heavy_plus_sign: added ability to insert images in original resolution when exporting to PDF  
:heavy_plus_sign: in the PDF export window added ability to select a color space  
:hammer: fixed bug with blank pages in Excel 2007 export  
:hammer: fixed bug in PDF and HTML exports with vertical position of text which height is bigger than object height  
:hammer: fixed bug with metafile images in RTFExport  
:hammer: fixed bug with Vertical Alignment = bottom in PDF export  
:hammer: fixed transparent images appearance in XPS export  
:hammer: fixed export empty images in XPS  
:hammer: fixed bug in preview of CSV export with small amount of rows  
:hammer: fixed bug with bold japanese fonts in PDF export  
:hammer: fixed bug with Exportable property  
:heavy_minus_sign: improved SVG export: added embedding images in file, HasMultipleFiles option was added, improved text rendering, text with angle, underlines added  
:heavy_minus_sign: changed work of export to Dropbox for using API 2.0 instead API 1.0  
:heavy_minus_sign: improved quality of images in Excel 2007 export  
:heavy_minus_sign: added converting  to Date format for Excel2007 export  

### [Extras]
:heavy_plus_sign: added RavenDB connector \Extras\Connections\FastReport.RavenDB  
:heavy_plus_sign: added SQL Anywhere connector \Extras\Connections\FastReport.SqlAnywhere  
:heavy_plus_sign: added new report demos: Pharmacode, Box  

### [Preview]
:heavy_plus_sign: added support of Right-to-Left Interface (RTL)  
:heavy_plus_sign: added mouse-relative zoom  

### [WebReport]
:heavy_plus_sign: added ToolbarBackgroundStyle.None (you can use WebReport.ToolbarColor instead bitmap from style)  
:heavy_plus_sign: added properties WebReport.UnlimitedWidth, WebReport.UnlimitedHeight for enable Unlimited size for all report pages (default: false - use report settings)  
:heavy_plus_sign: added property WebReport.Dialogs for enable or disable all report dialogs (default: true - enabled)  
:hammer: fixed bug with handling of onClick event in WebReport  
:hammer: fixed bug with Exportable = false objects in WebReport preview and print  

## Version 2017.1

### [Demos]
:heavy_plus_sign: added new example \Demos\C#\WPFViewer  
:heavy_plus_sign: added new example \Demos\MFC  

### [Designer]
:heavy_plus_sign: added possibility to select all tables in DataWizardForm  
:heavy_plus_sign: added CSV database connection  
:hammer: fixed bug with updating the script when loading another report  
:hammer: fixed bug with updating TextObject.Format  
:hammer: fixed bug with updating TextObject.Border  
:hammer: fixed bug with non-existing connection plugin  

### [Engine]
:heavy_plus_sign: added possibility to set picture location (URL) in PictureObject from database  
:heavy_plus_sign: added support of alphanumeric values in GS1-128 barcode  
:hammer: fixed bug with RichObject page break  
:heavy_minus_sign: optimized memory consumption  

### [Exports]
:heavy_plus_sign: added ability to export text as curves in PostScript and PPML exports  
:heavy_plus_sign: added property FastCloudStorageClient.ReportUrl containing the link to a report after uploading to FastReport Cloud  
:heavy_plus_sign: added possibility to send a report using XMPP/Jabber and FastReport Cloud  
:heavy_plus_sign: added support of PDF/X-4 standard  
:heavy_plus_sign: added CMYK color profile in the PDF export  
:heavy_plus_sign: added property HTMLExport.EnableMargins to use page margins in the output file (default: false)  
:hammer: fixed bug with font "Meiryo UI" in PDF export  
:hammer: fixed bug with export dates in german locale for Excel2007 export  
:hammer: fixed bugs with formatting in Word 2007 (docx) export  
:hammer: fixed bugs with formatting in OpenOffice Writer (Open Document Text) export  
:hammer: fixed export of GroupHeader and GroupFooter bands in FR3 export  
:hammer: fixed bug with exporting images in Metafile image export  
:heavy_minus_sign: added possibility of getting images from a stream by GetImage(..) method in XAMLExport, property name ToMultipleFiles changed to HasMultipleFiles  

### [Extras]
:heavy_plus_sign: added MongoDB connector \Extras\Connections\FastReport.MongoDB  
:heavy_plus_sign: added NosDB connector \Extras\Connections\FastReport.NosDB  
:hammer: fixed bug with displaying a list of tables in FastReport.MySQL  

### [Preview]
:heavy_plus_sign: added "Exports" and "Clouds" properties in PreviewControl to hide/show exports in the "Save" button drop-down menu  

### [WebReport]
:heavy_plus_sign: added property WebReport.ShowBackButton to display the "Back" button (return to previous report in the tabbed report)  
:heavy_plus_sign: added property WebReport.LogFile to log the errors in WebReport, may be combined with WebReport.Debug  
:heavy_plus_sign: added property WebReport.EnableMargins to use page margins in the output (default: false)  
:heavy_plus_sign: added support of Page.Fill in WebReport  
:heavy_plus_sign: added support of WebReport background color - WebReport.BackColor (default value: White)  
:hammer: fixed bug with printing from browser any reports with links to detailed report  
:hammer: fixed bug with displaying the scroll bars on 100% width and height  
:hammer: fixed bug with visualization of reports with unlimited page width/height  
:hammer: fixed bug with "Fit Width/Fit Page" zooming in the toolbar  
:hammer: fixed bug with multi-threading  
:hammer: fixed bug with TextObject.ParagraphOffset  
:heavy_minus_sign: changed progress picture  

## Version 2016.4

### [Designer]
:heavy_plus_sign: added TextOutline editor  
:hammer: fixed bug with disappearing of part PolyLineObject, PolygonObject after preview  

### [Engine]
:heavy_plus_sign: added new HtmlObject for using in the WebReport or HTML export  
:heavy_plus_sign: added event Report.CustomCalc for custom data processing  
:hammer: fixed issue with incorrect assembly loading in report script  

### [Exports]
:heavy_plus_sign: added compliance with PDF/X-3 in PDF export  
:heavy_plus_sign: added new property PDFExport.PDFCompliance  
:heavy_plus_sign: added property PDFExport.ColorProfile for using in PDF/X-3 compliance mode  
:heavy_plus_sign: added support of export pictures with lossless compression in PDF export  
:heavy_plus_sign: added property PDFExport.ImageLossless  
:heavy_plus_sign: added IsScrolled property in XAML export  
:hammer: fixed bug with validation of PDF/A compliance with hyperlinks in report  
:hammer: fixed bug with handling control symbols in Excel2007Export  
:hammer: fixed bug with html tags in Excel 2007 export  
:hammer: fixed bug with wrong format of negative value of cell with CustomFormat in Excel 2007 export  
:hammer: fixed bug with line-height in HtmlObject in HTML export  
:hammer: fixed bug with skipping sequences spaces in TextObject for Excel2007 and HTML exports  
:hammer: fixed bug with encryption in PDF export  
:heavy_minus_sign: depercated properties: PDFExport.PdfA, PDFExport.PdfACompliance)  

### [Extras]
:heavy_plus_sign: added connector SharePoint/"Office 365" \Extras\Connections\FastReport.SharePoint  
:heavy_minus_sign: updated German resources  

### [WebReport]
:heavy_plus_sign: added hyperlinks on page number functionality (works only with Layers = true)  
:heavy_plus_sign: added click event handler functionality (works only with Layers = true)  
:heavy_plus_sign: added detailed reports - hyperlinks on hidden report page or report file (works only with Layers = true)  
:heavy_plus_sign: added new property WebReport.ShowTabCloseButton (default value: false)  
:heavy_plus_sign: added new property WebReport.TabPosition (default value: TabPosition.InsideToolbar)  
:heavy_plus_sign: added new example for Single Page Application \Demos\C#\Web\SPADemo  
:heavy_plus_sign: added new enum member TabPosition.Hidden for hidding tabs from toolbar  
:heavy_plus_sign: added hyperlinks on bookmarks functionality (works only with Layers = true)  
:hammer: fixed bug with downloading in Android  
:hammer: fixed bug in WebReport with CacheDelay in MVC applications  
:hammer: fixed bug with URLEncoded Cookies in Online Designer call-back  
:hammer: fixed bug with null ID in MVC  
:hammer: fixed bug with skipping lead spaces in TextObject  
:hammer: fixed bug with page breaks on printing from browser  
:heavy_minus_sign: improved memory consumption  
:heavy_minus_sign: improved caching of reports  

## Version 2016.3

### [Designer]
:heavy_plus_sign: added welcome window displayed on the designer startup  
:heavy_plus_sign: added splash screen showing during loading designer  
:heavy_plus_sign: added new toolbar for editing of PolyLineObject, PolygonObject  
:heavy_plus_sign: added unsaved report indication in window title  
:heavy_plus_sign: added unlimited page width and height options to PageSetup window  

### [Engine]
:heavy_plus_sign: added new objects PolyLineObject, PolygonObject  
:heavy_plus_sign: added properties Page.UnlimitedHeight, Page.UnlimitedWidth  
:heavy_minus_sign: updated rotation drawing for angle of images  

### [Exports]
:heavy_plus_sign: added Bold, Italic simulation for "MS UI Gothic" font and similar in PDF export  
:heavy_plus_sign: added export in JSON  
:heavy_plus_sign: added property PDFExport.ShowPrintDialog for showing the print dialog after opening the PDF document  
:heavy_plus_sign: added export PolyLineObject, PolygonObject in PDF  
:heavy_plus_sign: added property PDFExport.TextInCurves for creating the PDF document without fonts  
:heavy_plus_sign: added possibility to send multiple reports as attachments in Email export  
:heavy_plus_sign: added ToMultipleFiles property in XAML export  
:hammer: fixed bug with shadows in HTML export  
:hammer: fixed bug with TextObject.Underlines in HTML export  
:hammer: fixed bug with images hash counting in PDF export  
:hammer: fixed bug with hyperlinks in Trial version in PDF export  
:hammer: fixed bug(Header added) in PostScript export  
:hammer: fixed bug with fonts in PostScript export  
:hammer: fixed bug with paths in exports: XAML, SVG, PostScript, PPML  
:hammer: fixed bug with pictures with size over the page in PDF export  
:hammer: fixed bug with <div> style(numbers format) in Html Layers export  
:heavy_minus_sign: improved drawing of dash-dot lines in PDF export for correct printing from the Chrome  
:heavy_minus_sign: improved export in Excel 2007 with enabled property Seamless  

### [Extras]
:heavy_plus_sign: added JsonConnectionEditor.cs in FastReport.Json connector (\Extras\Connections\FastReport.Json)  

### [WebReport]
:heavy_plus_sign: added properties Left, Top, Width, Height in CustomDrawEventArgs (can be used in WebReport.CustomDraw)  
:heavy_plus_sign: added properties WebReport.DocxRowHeightIs, WebReport.PdfShowPrintDialog  
:heavy_plus_sign: added function WebReport.PrintInPdf(bool ShowPrintDialog) for setup showing the Print Dialog in PDF  
:heavy_plus_sign: added showing Print Dialog in print in PDF  
:hammer: fixed bug with CustomDraw event inside TableObject and Matrix  
:hammer: fixed bug with incorrect MIME type in inline PDF printing  
:hammer: fixed bug with switching Localization in ASP.NET (not MVC)  
:heavy_minus_sign: usage examples of WebReport are updated and relocated to the \Demos\C#\Web folder  
:heavy_minus_sign: updated internal jQuery to v1.12.3  

## Version 2016.2

### [Designer]
:heavy_plus_sign: added support to select and drag-n-drop multiple items in the data window  
:hammer: fixed bug with drag-n-drop operation of parameter variables in the data window  

### [Engine]
:heavy_plus_sign: added property Config.ReportSettings.ImageLocationRoot for set the local root path of PictureObject.ImageLocation  
:heavy_plus_sign: added possibility to download maps from OpenStreetMap files (*.osm)  
:hammer: fixed bug with System.NullReferenceException after ShowPrepared method  

### [Exports]
:heavy_plus_sign: added support of clipping (TextObject.Clip) in PDF export  
:heavy_plus_sign: added filtering of html tags in CSV export  
:heavy_plus_sign: added support of LineHeight, ParagraphOffset in HTML export  
:heavy_plus_sign: added support of TextObject.TextOutline in PDF export  
:hammer: fixed bug with wrong frames in PDF export  
:hammer: fixed bug with packing of open type fonts in PDF export  
:hammer: fixed bug with bookmarks in Acrobat Reader  
:hammer: fixed bug with absent spaces behind tagged strings  

### [Service]
:heavy_plus_sign: added new methods (GetReportsListByPathXml, GetReportsListXml, GetGearListXml, GetPreparedReportByID, GetReportXml, PutReport) in FastReport.Service.dll  

### [WebReport]
:heavy_plus_sign: added interface for Online Designer with list of functions  
:heavy_plus_sign: added support of layered HTML in WebReport (WebReport.Layers) with better WYSIWYG  
:heavy_plus_sign: added event for rendering the custom objects in Web or overriding rendering of standard objects (WebReport.CustomDraw), works only with enabled WebReport.Layer  
:hammer: fixed bug with application cookies in Online Designer handlers  
:hammer: fixed bug with width of popup in toolbar menu  
:hammer: fixed bug with different localization (WebReport.LocalizationFile)  
:hammer: fixed bug with padding in WebReport  
:hammer: fixed bug with WebReport.XlsxWysiwyg  

## Version 2016.1

### [Demos]
:hammer: fixed bug with x86 in vb Demos/VB.Net/Main/Form1.vb  

### [Engine]
:heavy_plus_sign: added text outline with possibility to set color, width and style of line (property TextObject.TextOutline)  
:heavy_plus_sign: added property TextObject.TextOutline.DrawBehind  
:hammer: fixed bug with ResetPageNumber with multiple nested GroupHeaderBand  
:hammer: fixed bug with pointing of objects in Preview when Classic View of bands is enabled in Designer  
:hammer: fixed bug with exception on printing to disconnected printer  

### [Exports]
:hammer: fixed CRLF in ODT Export  
:hammer: fixed bug with out of range exception in PDFExportPictures.cs  

### [WebReport]
:heavy_plus_sign: added property WebReport.RefreshTimeout (time for report refresh in seconds, 0 - refresh disabled), this property may be useful for Dashboard functionality  
:hammer: fixed bug with download of exports by IE8 under Windows XP  
:hammer: fixed bug with multiple WebReport object on page  
:hammer: fixed bug with multiline TextObject in Dialogs  
:heavy_minus_sign: improved AJAX communication with server  

## Version 2015.4

### [Common]
:heavy_minus_sign: new install  
:heavy_minus_sign: now Online Designer is separate product, all Professional customers have got it for free  
:heavy_minus_sign: modified Main demo and report examples (\Demos\C#\Main)  

### [Designer]
:heavy_plus_sign: added import from DevExpress report template  

### [Engine]
:heavy_plus_sign: added text outline with possibility to set color, width and style of line (property TextObject.TextOutline)  
:heavy_minus_sign: improved speed of report prepare  
:heavy_minus_sign: reduced memory consumption  
:heavy_minus_sign: explained exception on invocation the events in script  

### [Exports]
:heavy_plus_sign: added export in FastReport Cloud  
:heavy_plus_sign: added font color tag parsing in RTF export  
:heavy_plus_sign: added exports in PPML (Personalized Print Markup Language) and PostScript - (classes PPMLExport, PSExport)  
:heavy_plus_sign: added EmbedPictures property in HTMLExport  
:heavy_plus_sign: added property Excel2007Export.Seamless for export table without breaks  
:hammer: export shapes(rectangle, rounded rectangle) in layer HTML export by using CSS  
:hammer: fixed bug with shadows in table-based exports  
:hammer: fixed code duplication in XAML, SVG, PPML, PostScript exports  
:hammer: fixed URL links in layer HTML export  
:heavy_minus_sign: rewrited saving in Excel 2007, Word 2007, Power Point 2007, XPS  
:heavy_minus_sign: reduced memory consumption in table based exports  
:heavy_minus_sign: increased speed of export in PDF, Excel 2007  

### [Online Designer]
:heavy_plus_sign: added html5 manifest for off-line working (without iframe)  
:heavy_plus_sign: added dialogue controls TextBox, RadioButton, Label, CheckBox, ButtonControl  
:heavy_plus_sign: added support of dialogue forms  
:heavy_plus_sign: added double-tap for mobile devices  
:heavy_plus_sign: added hotkeys help on button "h"  
:hammer: fixed bug with prefixes of connections  
:hammer: fixed bug with change the name of system variable  
:hammer: fixed bug with Font size for TextObject,  
:hammer: fixed bug with Padding after load  
:hammer: fixed bug with duplicate Dictionary in resulting report  
:hammer: fixed bug with copying of objects  
:hammer: fixed bug with move objects with hotkeys  
:hammer: fixed bug with lost connections in report on preview  
:heavy_minus_sign: optimization of report parser  
:heavy_minus_sign: changed the algorithm of selection of several objects  

### [WebReport]
:heavy_plus_sign: added property WebReport.DesignerLocale (set locale for Online Designer)  
:heavy_plus_sign: added property WebReport.EmbedPictures (embedding pictures in HTML)  
:heavy_plus_sign: added property WebReport.XlsxSeamless for export table without breaks in Excel 2007 format  
:hammer: fixed bug with rendering report with enabled property WebReport.SinglePage  
:hammer: fixed bug with default values of parameters  
:hammer: fixed bug with pictures with enabled property WebReport.SinglePage  
:hammer: fixed bug with multiline TextBox  
:hammer: fixed bug with Azure cookies  

## Version 2015.3

### [Designer]
:heavy_plus_sign: added ability to use FastReport.dll without FastReport.Bars.dll if the designer is not shown  
:hammer: fixed bug with incorrect display of Japanese characters in Ribbon bar  
:hammer: fixed bug "Code tab loses focus to events window when typing"  
:hammer: fixed bug with deleting page after "CTRL+C -> CTRL+V -> DEL -> CLICK" sequence  
:heavy_minus_sign: drop-down list width in relations editor now corresponds with items width  

### [Engine]
:hammer: fixed bug with change of application working path on call of Report.Prepare  

### [On-line Report Designer]
:heavy_plus_sign: improved read Connections and DataSources from report  
:heavy_plus_sign: auto set of DataSource to the band on first drag-n-drop of database field  
:heavy_plus_sign: added context menu in Report Tree for objects and bands  
:heavy_plus_sign: added context menu for bands  
:heavy_plus_sign: added context menu for MatrixObject  
:heavy_plus_sign: added new styles for MatrixObject  
:heavy_plus_sign: added ability for open blank report without load of default template in WebReport  
:heavy_plus_sign: added editor of DataBand, GroupHeaderBand on double-click and 'Edit' in context menu  
:heavy_plus_sign: added 'Delete' in context menu of bands  
:heavy_plus_sign: added DatePicker for data selection in some fields in properties  
:heavy_plus_sign: added new tab "Report" in main menu with items Preview, Page, Save  
:heavy_plus_sign: added helper button in right corner with hot-keys information  
:heavy_plus_sign: added the popup window for edit the PictureObject  
:heavy_plus_sign: added ability in config-data file to enable of progress indicator for save the report (property show-saving-progress)  
:heavy_plus_sign: added showing of DataSource Relations  
:heavy_plus_sign: added deleting of cell with Totals in context menu of MatrixObject  
:heavy_plus_sign: added property in configuration file 'notifications', which change the type of notification ('default' or 'HTML5 Notifications'), or disable  
:heavy_plus_sign: added change the size of the row or column of the table with the mouse  
:heavy_plus_sign: added properties in configuration file 'show-properties', 'show-events', 'show-rt', 'show-data' for enable or disable panels  
:heavy_plus_sign: added tooltip for text objects with content greater than the size  
:heavy_plus_sign: added context right mouse button menu on some objects  
:heavy_plus_sign: added property in configuration file 'default-tab-menu' for setting default menu tab  
:hammer: fixed bug with filters in data-bands and with html tags in text objects  
:hammer: fixed bug with invisible icons in on-line Designer  
:hammer: fixed json syntax error in configuration file  
:hammer: fixed bug with adding of GroupHeaderBand with DataBand and wrong position  
:hammer: fixed bug with saving of padding in text objects  
:hammer: fixed bug with save of Maps  
:hammer: fixed bug with quotes in report script  
:hammer: fixed bug with aliases for data sources in expressions  
:heavy_minus_sign: if the column of DataSource has the neested columns (or neested DataSources), then they show in Data panel  
:heavy_minus_sign: added context menu for components  
:heavy_minus_sign: window with delete confirmation of object|band is no longer shown  
:heavy_minus_sign: added colorpicker plugin for browsers (such as IE) without support of input type color  

### [WebReport]
:heavy_plus_sign: added support of Windows Azure working environment  
:heavy_plus_sign: added properties WebReport.InlineRegistration, WebReport.ShowAfterPrepare  
:heavy_plus_sign: added new property WebReport.Debug  
:heavy_plus_sign: added ability to save report from On-line Designer through POST query in call-back page (when WebReport.DesignerSavePath is blank)  
:heavy_plus_sign: added property WebReport.CloudEnvironmet for enable compatibility with Azure environment  
:heavy_plus_sign: added event WebReport.OnSaveDesignedReport for work with saved report after On-line Designer (field FastReport.Web.SaveDesignedReportEventArgs.Stream)  
:heavy_plus_sign: added methods for direct export in file from browser WebReport.ExportPdf(), WebReport.ExportOds(), etc.  
:hammer: fixed bug with script registration  
:hammer: fixed bug with file name with spaces in export  
:hammer: fixed issues with WebReport.RegisterData  
:hammer: fixed bug with Parameters  
:hammer: fixed bug with size when height is 100% in Online designer mode  
:hammer: fixed bug with support of HTTPS on run the call-back page for save the report from On-line Designer  
:hammer: fixed bug with preview the reports with dialogs from On-line Report Designer  
:hammer: fixed bug with access to files on debug under Visual Studio with IIS server  
:hammer: fixed bug with serialization under Web Garden or Web Farm mode  
:heavy_minus_sign: improved error reporting  
:heavy_minus_sign: optimization of memory consumption  

## Version 2015.2

### [Designer]
:heavy_plus_sign: added Preview button in File menu in Ribbon toolbar  

### [Engine]
:hammer: fixed bug with opening frx/fpx files with Unicode signature in begin of file  
:hammer: fixed bug with CantFindObject exception in report reader in WebMode  
:hammer: fixed bug with saving empty Excel 2007 files  
:hammer: fixed RichTextQuality in PDF export  
:heavy_minus_sign: updated Japanese resources  

### [On-line Report Designer]
:heavy_plus_sign: added objects SimpleGauge, LinearGauge  
:heavy_plus_sign: added corners highlight of selected objects  
:heavy_plus_sign: added scale of report page with "ctrl + mousewheel"  
:heavy_plus_sign: added barcodes Aztec, Plessey, GS1-128/EAN-128  
:heavy_plus_sign: added support of hierarchical data arrays with BusinessObjects  
:heavy_plus_sign: added Aliases for data sources  
:heavy_plus_sign: added copy/paste of TableObject and MatrixObject  
:heavy_plus_sign: added enable/disable of rows/columns in tabled objects  
:heavy_plus_sign: added MatrixObject  
:heavy_plus_sign: added more space between bands  
:heavy_plus_sign: band height reduced twice on mobile devices  
:heavy_plus_sign: cancel of creating object by ESC  
:heavy_plus_sign: added save of report on keys "ctrl + s"  
:hammer: fixed bug with duplicate component/bands names  
:hammer: fixed bug with cell deletion in table object  
:hammer: fixed bug with deletion of child bands in last band of page  
:hammer: fixed bug with band resize to 0  
:hammer: fixed bug with save of included objects in frx report  
:hammer: fixed bug in TableObject with adding of rows and columns  
:hammer: fixed bug in TableCell with RowSpan and ColSpan  
:hammer: fixed bug with table witdh and height  
:hammer: fixed bug with selecting of non valid fields  
:hammer: fixed bug with showing of messages when toolbar is hidden  
:hammer: fixed bug with moving of child cells of table beside a left side  
:hammer: fixed bug with adding of new object on the mobile devices  
:hammer: fixed bug with create object on scaled page  
:hammer: fixed bug with create object inside a cell of table  
:hammer: fixed bug with positioning of LineObject in Firefox  
:heavy_minus_sign: changed panels with properties and events  
:heavy_minus_sign: improved work with TableObject  
:heavy_minus_sign: changed design of trees in Report Tree, data and in Expression Editor  
:heavy_minus_sign: improved of parse of report with error reporting  
:heavy_minus_sign: the icons are same as in desktop designer  
:heavy_minus_sign: added tab View change of settings of grid and units  
:heavy_minus_sign: changes in style of object creation  
:heavy_minus_sign: changed search algorithm of objects on page with selection  

### [Service]
:heavy_plus_sign: added report exporting methods in Service  

### [WebReport]
:heavy_plus_sign: added export in Prepared report  
:hammer: fixed bug with exception CantFindObject in WebReport  
:hammer: fixed bug with preview from designer in ASPX mode  
:hammer: fixed bug with designer position  
:hammer: fixed bug with report load in designer in ASPX mode  
:heavy_minus_sign: page breaks in export to Excel 2007 from WebReport now disabled by default  

## Version 2015.1

### [Common]
:heavy_plus_sign: added on-line HTML5 Report Designer (beta) in WebReport - available in Trial and Professional editions (\FastReport.Net\Source\FastReport.Web\WebReportDesigner)  
:heavy_plus_sign: added new Ribbon toolbar in Report Designer  
:heavy_plus_sign: added new interface styles in Designer: Office 2010 (Silver), Office 2010 (Blue), Office 2010 (Black), Visual Studio 2010, Visual Studio 2012 (Light), Office 2013  
:heavy_plus_sign: added RESTful service in FastReport.Service.dll  
:heavy_plus_sign: added new Aztec, Plessey barcode  
:heavy_plus_sign: added GS1-128 (formerly known as UCC-128 or EAN-128) barcode. Currently supports only numeric values.  
:heavy_plus_sign: added new properties in WebReport: DesignReport, DesignScriptCode, DesignerPath, DesignerSavePath, DesignerSaveCallBack, PrintInBrowser, SinglePage  
:heavy_plus_sign: added property CSVExport.NoQuotes that disables quotation marks in CSV export  
:hammer: fixed bug with export in PDF/A  
:hammer: fixed bug in WebReport with 'Access to the path \FastReport\ is denied'  
:hammer: fixed bug with memory leak in PDF export  
:hammer: fixed bug with Gauge object in Word 2007 export  
:hammer: reduced memory consumption in WebReport  
:hammer: fixed bug with caching of report results by browser in WebReport  
:heavy_minus_sign: updated japanese, greek resources  
:heavy_minus_sign: updated demos \Demos\C#\MvcRazor,\Demos\C#\WCFWebService,\Demos\C#\WCFWebClient  

## Version 2014.4

### [Common]
:heavy_plus_sign: added an AutoSave feature in a Designer, you can enable it and set a time interval in View-Options-Saving  
:heavy_plus_sign: added support of dialog objects ListBoxControl, CheckedListBoxControl in WebReport  
:heavy_plus_sign: added options for selection of PDF/A compliance, Jpeg quality, Initial Zoom in PDF export dialog  
:heavy_plus_sign: added new property PDFExport.PdfACompliance (can be selected from PdfAStandard.PdfA_2a, PdfAStandard.PdfA_2b, PdfAStandard.PdfA_3a, PdfAStandard.PdfA_3b)  
:heavy_plus_sign: added compliance of PDF/A-2a,b and PDF/A-3a,b in PDF export  
:heavy_plus_sign: added transparency of the image in PDF export  
:heavy_plus_sign: added text editor for barcodes  
:heavy_plus_sign: added selection of barcode type on a toolbar in a Designer  
:heavy_plus_sign: added proportionally scaling of objects with SHIFT in a Designer  
:heavy_plus_sign: added selection of multiple objects with CTRL key in a Designer  
:heavy_plus_sign: added "Enable Code Completion" checkbox in Code Page Options in a Designer  
:heavy_plus_sign: added picture editor in a Designer, now pictures can be resized, cropped and modified to grayscale or monochrome  
:heavy_plus_sign: added support of encodings Windows-1251, cp866 in QR-code object  
:hammer: fixed bug in Designer with save from code editor (save icon is not active after code change)  
:hammer: fixed bug with band break  
:hammer: fixed bug with single page export in PDF  
:heavy_minus_sign: improved speed of PDF export with transparent images (now it three times faster)  

## Version 2014.3

### [Common]
:heavy_plus_sign: added QR-code editor in designer  
:heavy_plus_sign: added MonthCalendar object in WebReport  
:heavy_plus_sign: added processing of event handlers Load, FormClosing and FormClosed in DialogPage in WebReport  
:heavy_plus_sign: added CSV export in WebReport  
:heavy_plus_sign: added new property DefaultPage in PDFExport  
:heavy_plus_sign: added new property DefaultZoom in PDFExport  
:heavy_plus_sign: increased customization options of scale in simple gauge  
:heavy_plus_sign: added new property Inverted in linear gauge  
:heavy_plus_sign: added new properties AllowExpression, Brackets in Barcode object  
:heavy_plus_sign: added vertical simple gauge  
:heavy_plus_sign: added simple gauge  
:heavy_plus_sign: added vertical linear gauge  
:heavy_plus_sign: added import from List & Label report template  
:heavy_plus_sign: added WebMatrix demo (\Demos\C#\WebMatrix)  
:hammer: fixed bug with landscape pages in Word 2007 (docx) export  
:hammer: fixed bug with HTML-tags in RTF export  
:hammer: fixed bug with line spacing in RTF export  
:hammer: fixed bug with metafile size in RTF export  
:hammer: fixed bug with spaces in file names in exports in WebReport  
:hammer: fixed bug with scaling of linear gauge  
:hammer: fixed bug with selecting all text (Ctrl+A) in the object inspector in designer  
:hammer: fixed bug with refresh of DateTimePicker in WebReport  
:heavy_minus_sign: updated German, French, Japanese resources  

## Version 2014.2

### [Common]
:heavy_plus_sign: added connector Google BigQuery \Extras\Connections\FastReport.GoogleBigQuery  
:heavy_plus_sign: added an example of Google BigQuery access \Demos\C#\GoogleBigQuery  
:heavy_plus_sign: added save to Box cloud from preview  
:heavy_plus_sign: added support of line-spacing in RTF and DOCX exports  
:hammer: fixed bug with fonts in SVG export  
:hammer: fixed bug with default message in ProgressBar window  
:hammer: fixed bug with AVG function in Map editor  
:hammer: fixed bug in font packing subsystem (in some rare cases the OS/2 table was overlapped by other tables)  
:hammer: fixed bug with artifact lines in RoundRectangle with big Curve value  
:hammer: fixed bug with ParagraphOffset in RTF export  
:hammer: fixed bug with hints in WebReport toolbar  
:heavy_minus_sign: increased speed of database access (up to 6 times faster)  
:heavy_minus_sign: changed output of language names in an interface language selection dialog  
:heavy_minus_sign: updated German, Japanese resources  

## Version 2014.1

### [Common]
:heavy_plus_sign: added compatibility with Fips Algorithm Policy (with limitations: encryption of PDF export, encryption of report)  
:heavy_plus_sign: added new demo of localization and customization in Webreport (Demos\C#\MvcCustomization\)  
:heavy_plus_sign: added custom icons and background in WebReport toolbar  
:heavy_plus_sign: added localization in WebReport (property WebReport.LocalizationFile)  
:heavy_plus_sign: added support html tags <B>, <I>, and <U> to RTF export.  
:heavy_plus_sign: added export in SVG  
:heavy_plus_sign: added support of PDF/A in PDF export  
:hammer: fixed bug with showing of invisible dialog pages in WebReport  
:hammer: fixed bug with rendering of ASP.NET WebReport control in design-time  
:hammer: fixed bug with borders in XAML export  
:hammer: fixed bug with an additional empty page in the export to the MS Word 2007  
:hammer: fixed bug with bookmarks in PDF export  
:hammer: fixed bug when inserting gauge  
:hammer: fixed the line spacing in a layered export to Word 2007  
:hammer: fixed bug with paragraphs in RTF & Word2007 exports  
:hammer: fixed bug with incorrect server address in save to FTP server  
:heavy_minus_sign: added default action to the Print buttion in WebReport when WebReport.PrintInPdf = false;  

## Version 2013.4

### [Common]
:heavy_plus_sign: added multi tabs preview in WebReport  
:heavy_plus_sign: added export in XAML  
:heavy_plus_sign: added linear gauge object in designer  
:heavy_plus_sign: added demo report for linear gauge (Gauge.frx)  
:hammer: fixed bug in PDF export with extra large bitmaps  
:hammer: fixed bug with rendering of ASP.NET WebReport control in design-time  
:hammer: fixed bug with PrintOn.FirstPage | PrintOn.LastPage  
:hammer: fixed bug with digit count in numbers in exports  
:hammer: fixed bug with invisible objects (out of page bounds) in table-based exports  
:hammer: fixed bug with linespacing in layered export in Word2007  
:heavy_minus_sign: show band name in the total editor form's bandcombobox  

## Version 2013.3

### [Common]
:heavy_plus_sign: added new object SparklineObject (compact chart based on MSChartObject)  
:heavy_plus_sign: added Slovenian localization  
:heavy_plus_sign: added WeekOfYear function  
:heavy_plus_sign: added property WebReport.ExternalJquery (default: false) for enable or disable jQuery in WebReport (ASPX)  
:heavy_plus_sign: added new methods WebReportGlobals.ScriptsWOjQuery() and WebReportGlobals.StylesWOjQuery() for disable jQuery in WebReport (MVC Razor)  
:heavy_plus_sign: added demo of WCF web-client \Demos\C#\WCFWebClient  
:heavy_plus_sign: added demo of WCF Windows client \Demos\C#\WCFClient  
:heavy_plus_sign: added demo of WCF web-service \Demos\C#\WCFWebService  
:heavy_plus_sign: added demo of Windows Service \Demos\C#\WCFWindowsService with WCF Service Library  
:heavy_plus_sign: added Windows Communication Foundation (WCF) Service Library FastReport.Service.dll  
:heavy_plus_sign: added save to FTP from preview  
:hammer: fixed bug in Excel 2007 export with empty page name  
:hammer: fixed bug in Excel 2007 export with styles for multi-page report template  
:hammer: fixed bug in PDF export with print from Acrobat Reader with hyperlinks in document  
:hammer: fixed bug with the re-export to PDF from code  
:hammer: fixed bug in PDF export with double frame borders  
:hammer: fixed bug in Maps with file permissions  
:heavy_minus_sign: report.RegisterData(ds) replace existing datasources  

## Version 2013.2

### [Common]
:heavy_plus_sign: added support of ASP.NET MVC framework (ASPX, Razor) in WebReport  
:heavy_plus_sign: added Greek localization  
:heavy_plus_sign: added save in cloud Google Drive from preview  
:heavy_plus_sign: added new demos using WebReport in MVC - \Demos\C#\MvcDemo, \Demos\C#\MvcRazor  
:hammer: fixed bug with MasterPages in WebReport  
:hammer: fixed bug with WebReport.RepotDone  
:hammer: fixed bugs in WebReport with styles  
:hammer: fixed bug with embedding of monospaced fonts in PDF and XPS exports  
:hammer: fixed bug with cell duplication on merged cells in Excel 2007 export  
:hammer: fixed bug with font transparency of empty cells in Excel 2007 export  
:hammer: fixed bug with broken formats after matrix optimization in Excel 2007 export  
:hammer: fixed excel numeric formats bug  
:hammer: fixed bug with encoding when importing dDase file of Map in DBX export  
:hammer: fixed bug in Dropbox with NullReferenceException  
:hammer: fixed bug in Dropbox export when Application Key and Secret  
:hammer: fixed bug with printing chart legend  
:hammer: fixed bug in PictureObject  
:heavy_minus_sign: iMPORTANT! changed extension of WebReport handler (from FastReport.Export.aspx to FastReport.Export.axd), please check existing web.config  

## Version 2013.1

### [Common]
:heavy_plus_sign: added dialogs in WebReport (some controls and features are in development now)  
:heavy_plus_sign: added Label property to chart series  
:heavy_plus_sign: added Armenian localization  
:heavy_plus_sign: added anchors support in the PDF export  
:heavy_plus_sign: added PrintOn.SinglePage to the PrintOn property (doublepass must be enabled)  
:heavy_plus_sign: added AdjustSpannedCellsWidth property in Matrix and Table objects  
:heavy_plus_sign: added new customizable toolbar in WebReport  
:heavy_plus_sign: added AJAX in WebReport  
:heavy_plus_sign: added save in cloud SkyDrive from preview  
:heavy_plus_sign: added save in cloud Dropbox from preview  
:heavy_plus_sign: added map editor in designer  
:heavy_plus_sign: added Map object  
:heavy_plus_sign: added Wysiwyg property in Word 2007 export  
:hammer: fixed bug in the Word 2007 export in layer mode  
:hammer: fixed bug in the TXT export  
:hammer: fixed drag&drop bug in the code editor  
:hammer: fixed bug when saving report to .cs/.vb file  
:hammer: fixed bug with number format in Excel exports  
:hammer: fixed bug in VB.Net code generator  

## Version 1.9

### [Common]
:heavy_plus_sign: added WebReport.XmlExcelDataOnly property  
:heavy_plus_sign: added BackPage property to the report page  
:heavy_plus_sign: added Config.PreviewSettings.PreviewOpened event  
:heavy_plus_sign: added Exportable property to all report objects  
:heavy_plus_sign: added support of UNC paths in WebReport storage (web.config)  
:heavy_plus_sign: added QR Code barcode  
:hammer: fixed bug in WebReport with multiple instances in one page  
:hammer: fixed bug with TableObject border when exporting to some formats  
:hammer: fixed bug with pictures in PDF export  
:hammer: fixed bug with Config.DesignerSettings.ApplicationConnection  
:hammer: fixed bug with multiple preview tabs  
:hammer: fixed bug with subreport & band that can break  
:hammer: fixed bug with subreport & databand columns  
:hammer: fixed bug in WebReport with cleanup of internal storage  
:hammer: fixed bug with data filtering with NumericUpDown control  
:heavy_minus_sign: approved compatibility with Visual Studio 2012  
:heavy_minus_sign: improved printing of data in the headers/footers  
:heavy_minus_sign: improved WebReport  
:heavy_minus_sign: improved TableObject performance  

## Version 1.8

### [Common]
:heavy_plus_sign: added Web Farms and Web Gardens support in WebReport (example \Demos\C#\WebFarm\Web.Config)  
:heavy_plus_sign: added WebReport.CachePriority property  
:heavy_plus_sign: added HoverStyle property to all report objects  
:hammer: fixed bug in PDF export (images and encryption)  
:hammer: fixed padding when exporting to RTF/Word2007  
:hammer: fixed bug when invoking WebReport component designer  
:hammer: fixed bug with printing/exporting interactive reports  
:hammer: fixed bug with two-pass report and business object datasource  
:hammer: fixed bug with null thickness and Dash or Dot style of lines in the PDF export  
:hammer: fixed bug with report parameters and undo/redo  
:hammer: fixed bug with subreport and KeepTogether  
:hammer: fixed bug with images when editing a prepared report  
:hammer: fixed bug in Crystal Reports import plugin (incorrectly converted groups)  
:hammer: fixed bug in Crystal Reports import plugin (PaperOrientation property converted incorrectly)  
:hammer: fixed bug in Crystal Reports import plugin (report creation date converted incorrectly)  
:hammer: fixed bug in Crystal Reports import plugin (kind of some sections converted incorrectly)  
:hammer: fixed bug with empty subreport  
:hammer: fixed bug when opening RDL-file from recent files list  
:hammer: fixed bug in Crystal Reports import plugin (incorrectly converted paper size for formats B4 and B5)  
:hammer: fixed number format when exporting to Excel  
:heavy_minus_sign: improved WebReport using ControlState instead of ViewState, increased speed and stability  

## Version 1.7

### [Common]
:heavy_plus_sign: added Config.DesignerSettings.PageAdded event  
:heavy_plus_sign: added ability to hide some objects (export filters, report objects) by the code: RegisteredObjects.FindObject(typeof(PDFExport)).Enabled = false  
:heavy_plus_sign: added TableObject.ManualBuildAutoSpans property  
:heavy_plus_sign: added properties TableRow.KeepRows, TableColumn.KeepColumns  
:heavy_plus_sign: added outline in the PDF export  
:heavy_plus_sign: added MatrixObject.KeepCellsSideBySide property  
:heavy_plus_sign: added import plugin from Crystal Reports  
:heavy_plus_sign: added Report.MaxPages property  
:heavy_plus_sign: added Config.PreviewSettings.AllowPrintToFile property  
:hammer: fixed bug when exporting to metafile  
:hammer: fixed bug with band's CanBreak and outline  
:hammer: fixed bug with grid alignment  
:hammer: fixed bug in PDF export (missing pictures when viewing under MAC OS or iOS)  
:hammer: fixed RichObject height issue  
:hammer: fixed bug with events  
:hammer: fixed bug with text break  
:hammer: fixed bug with some image types  
:hammer: fixed bug when saving the report as a class  
:hammer: fixed bug in the report preview  
:hammer: fixed bug in RichObject  
:hammer: fixed bug with page borders and fill in the PDF export  
:hammer: fixed bug with information fields in the encrypted PDF file  
:hammer: fixed bug with band break  
:hammer: fixed memory leak when exporting to PDF with embedded fonts  
:hammer: fixed bug with rendering of text in WebReport when TextObject.WordWrap = false;  
:hammer: fixed bug with unary minus with totals  
:hammer: fixed bug with watermark  
:heavy_minus_sign: checkBoxObject is available in the Basic edition  
:heavy_minus_sign: improved .fpx loading speed/memory usage  
:heavy_minus_sign: improved report file cache  

## Version 1.6

### [Common]
:heavy_plus_sign: added Report.InitialPageNumber property  
:heavy_plus_sign: added Open Document Text, XPS, DBF exports in WebReport  
:heavy_plus_sign: added FNC1 symbol encoding in the Datamatrix barcode (use &1; sequence)  
:heavy_plus_sign: added saving of TextObject.Angle property when saving template in RDL format  
:heavy_plus_sign: added import of WritingMode property when import template from RDL format  
:heavy_plus_sign: added Thai localization  
:heavy_plus_sign: added IsNull function to check DB columns for null  
:heavy_plus_sign: added PreviewControl.UseBackColor property  
:heavy_plus_sign: added ability to save template to RDL format (Report Definition Language)  
:heavy_plus_sign: added TextObject.ParagraphOffset property  
:heavy_plus_sign: added Romanian and Hungarian localization  
:hammer: fixed bug with ChartObject filter when saving the report as a C#/VB.Net class  
:hammer: fixed bug in the Group Expert  
:hammer: fixed bug when opening some saved to RDL reports in the Report Builder  
:hammer: fixed RichObject multi-thread issues  
:hammer: fixed bug when saving the prepared report with UseFileCache flag  
:hammer: fixed bug in TextObject.TabWidth  
:hammer: fixed bug in TextObject break  
:hammer: fixed bug with RichObject and CanShrink  
:hammer: fixed "Scale" print mode  
:hammer: fixed bug when converting boolean expressions in the RDL import  
:hammer: fixed bug with internal manifest in ODF export  
:heavy_minus_sign: changed work of exports and printing in WebReport, now we use handlers in "web.config"  
:heavy_minus_sign: added ability to replace built-in query builder  

## Version 1.5

### [Common]
:heavy_plus_sign: added import from RDL format (Report Definition Language)  
:heavy_plus_sign: added properties WebReport.ShowWord2007Export, WebReport.DocxMatrixBased  
:heavy_plus_sign: added properties WebReport.PrintWindowWidth, WebReport.PrintWindowHeight  
:heavy_plus_sign: added property WebReport.PrintInPdf (enable for PDF printing or disable for browser printing)  
:heavy_plus_sign: added inline printing from browser in WebReport  
:heavy_plus_sign: added DataLoaded event to all dialog controls that support data filtering  
:heavy_plus_sign: added Config.ReportSettings.ReportPrinted event  
:heavy_plus_sign: added property HTMLExport.Layers and a checkbox in the dialog of the HTML export (enable layers in HTML file)  
:heavy_plus_sign: added TotalsFirst option for the matrix totals  
:heavy_plus_sign: added calculation of percents in the Matrix object  
:heavy_plus_sign: added support for custom functions in the matrix totals  
:heavy_plus_sign: added Slovak localization  
:heavy_plus_sign: added properties PDFExport.JpegQuality and PDFExport.RichTextQuality (default value is 90 in both)  
:heavy_plus_sign: added DataBand.ResetPageNumber property  
:heavy_plus_sign: added Word 2007 (docx) export  
:heavy_plus_sign: added XPS export  
:hammer: fixed bug with static query parameters and master-detail report  
:hammer: fixed bug with FirstTabOffset  
:hammer: fixed bug with subreport and multi-column band  
:hammer: fixed bug with CheckedListBoxControl + cascaded filter  
:hammer: fixed bug in RTF export with similar pictures  
:hammer: fixed bug with report outline  
:hammer: fixed bug when rendering several side-by-side Table objects  
:hammer: fixed bug with paper size  
:hammer: fixed "keep with data" + multicolumn databand  
:hammer: fixed text object's html tags + "underline" font style  
:hammer: fixed bug in the PowerPoint export  
:hammer: fixed bug with Matrix and EvenStyle  
:heavy_minus_sign: improved TextObject.Duplicates  
:heavy_minus_sign: dbfExport properties FieldNamesFileName, LoadFieldNamesFromFile replaced with FieldNames property  

## Version 1.4

### [Common]
:heavy_plus_sign: added Visual Studio 2010 support  
:heavy_plus_sign: added support of font subsets in PDF export  
:heavy_plus_sign: added SQL CE connection  
:heavy_plus_sign: added HierachyRow# system variable which returns the row number like "1.2.1" in the hierarchical report  
:heavy_plus_sign: added support for table schema in OleDB and ODBC connectors  
:heavy_plus_sign: added NumToWordsEs function for spanish  
:heavy_plus_sign: added Dutch localization  
:heavy_plus_sign: added Ukrainian localization  
:heavy_plus_sign: added Config.ReportSettings.DefaultPaperSize property  
:heavy_plus_sign: added HTMLExport.Print property (show the browser's print dialog when html document is opened, available only in "single page" mode)  
:heavy_plus_sign: added HTMLExport.PageBreaks property (insert hard page breaks in "single page" mode)  
:heavy_plus_sign: added band.FirstRowStartsNewPage property  
:heavy_plus_sign: added Parameter.Description property  
:heavy_plus_sign: added Config.TempFolder property  
:heavy_plus_sign: added report.ReportInfo.PreviewPictureRatio property  
:heavy_plus_sign: added DataBand.PrintIfDatasourceEmpty property  
:heavy_plus_sign: added ChildBand.PrintIfDatabandEmpty property  
:heavy_plus_sign: added Config.DesignerSettings.Restrictions.DontCreateData restriction to disable the "Data|Add Data Source..." menu  
:heavy_plus_sign: added ForceLoadData property to all datasources  
:hammer: fixed bug in the query builder (wrong join type)  
:hammer: fixed dialogue forms controls order  
:hammer: fixed bug with Dock != None and CanGrow, CanShrink  
:hammer: fixed bug in HTML export  
:hammer: fixed bug with "Save printer in the report file" option  
:hammer: fixed bug in Chart object (ClearValues method does not work)  
:hammer: fixed bug in the Data Wizard  
:hammer: fixed bug in totals when the "Convert null values" option is off  
:hammer: fixed bug with saving report as VB class  
:hammer: fixed bug with dialog controls attached to a calculated column  
:hammer: fixed outline in a hierarchical report  
:hammer: fixed bug in the Data Wizard under Vista OS  
:hammer: fixed bug with embedded TTC fonts in PDF export  
:hammer: fixed bug when exporting TableObject with invisible rows  
:hammer: fixed bug in the Chart object (when trying to group unsorted data by months)  
:hammer: fixed bug with registration of plugins  
:hammer: fixed bug with bands which CanBreak and StartNewPage properties set to true  
:hammer: fixed bug in HTML export (skip of styles when many pages exported in "single page" mode)  
:hammer: fixed bug with Row# and StartNewPage  
:hammer: fixed bug with Nullable custom functions  
:heavy_minus_sign: improved "Data Wizard" dialog (loading the table list is much faster now)  
:heavy_minus_sign: designer command DesignerControl.cmdData replaced with cmdAddData and cmdChooseData commands  
:heavy_minus_sign: reduced the resulting file size in HTML export  
:heavy_minus_sign: improved performance with very deep business objects  
:heavy_minus_sign: tables in the "Data Wizard" window are sorted now, "Sort tables" button removed  
:heavy_minus_sign: small improvements in the Data window (ability to move up/down the report parameters using Ctrl+Up/Down keys)  
:heavy_minus_sign: the installer is now automatically adds all FastReport.Net assemblies to the GAC  
:heavy_minus_sign: assembly FastReport.dll split into two parts - FastReport.dll, FastReport.Web.dll  

## Version 1.3

### [Common]
:heavy_plus_sign: added monochrome TIFF export  
:heavy_plus_sign: added Excel 2007 export  
:heavy_plus_sign: added PowerPoint 2007 export  
:heavy_plus_sign: added MHT (web-archive) export  
:heavy_plus_sign: added DBF export  
:heavy_plus_sign: added ODBC connection  
:heavy_plus_sign: added Oracle ODP.NET connection  
:heavy_plus_sign: added ability to print copy name on the printed page (see "Features/Print Copy Names" report)  
:heavy_plus_sign: added built-in support for cascaded data filtering (DetailControl property). See the "Dialogs/Cascaded Data Filtering" report  
:heavy_plus_sign: added "apply" flags to the style elements  
:heavy_plus_sign: added band's context menu items for easy creation of child band and detail data band  
:heavy_plus_sign: added TextObject.NullValue property (to replace null values with specified string)  
:heavy_plus_sign: added TextObject.ProcessAt property (allows to print totals in the header)  
:heavy_plus_sign: added the ImageExport.MonochromeTiffCompression property  
:heavy_plus_sign: added HTMLExport.WidthUnits, HTMLExport.HeightUnits properties (allows selection between Pixel and Percent)  
:heavy_plus_sign: added the Message-HTML (MHT, MHTML, web-archive) mode in HTML export (HTMLExport.Format property)  
:heavy_plus_sign: added Config.DesignerSettings.FilterConnectionTables event  
:heavy_plus_sign: added DataSourceBase.Load event to load detail rows in code  
:heavy_plus_sign: added Croatian localization  
:heavy_plus_sign: added Persian localization  
:heavy_plus_sign: added new demo projects in the Demos\VB.Net folder  
:heavy_plus_sign: added "Script/Sort Group By Total" report  
:hammer: fixed bug in business objects (duplicate datasource names)  
:hammer: fixed bug in dialogue forms (switch to the dialog page may throw an exception)  
:hammer: fixed bug in query builder  
:hammer: fixed bug with OutlineExpression and RepeatOnEveryPage  
:hammer: fixed bug with KeepChild  
:hammer: fixed bug with exporting barcodes  
:hammer: fixed bug in dialogue controls (Enabled & data filtering)  
:hammer: fixed bug with RepeatOnEveryPage band with child  
:hammer: fixed Matrix&Table bug (infinite loop if there is not enough space to print a column)  
:hammer: fixed bug in PDF export (file structure)  
:hammer: fixed designer exception when copying the total  
:hammer: fixed exception when closing the designer  
:hammer: fixed bug with disabling the navigator in HTML export  
:hammer: fixed bug with size of WebReport in percents  
:hammer: fixed PDF export (digits substitution in Arabic)  
:hammer: fixed bug with sorting on a calculated column  
:hammer: fixed bug in the PDF export (export of band with zero height and non-solid fill)  
:hammer: fixed bug in the text/expression editor (drag&drop items from the data tree)  
:hammer: fixed bug in the Excel 2007 export  
:hammer: fixed bug in the printer settings dialog (printer properties)  
:hammer: fixed bug with Outline when several reports are joined into one  
:hammer: fixed bug in Medium Trust mode  
:hammer: fixed search in the preview  
:hammer: fixed bug with MS SQL connection (can't use tables in schemas other than dbo.*)  
:hammer: fixed bug with Matrix and Table objects (Visible property is not working)  
:hammer: fixed bug in the group when there is no data to display  
:heavy_minus_sign: improved "Keep with data" mechanism  

## Version 1.2

### [Common]
:heavy_plus_sign: added Functions in the "Data" window  
:heavy_plus_sign: added new report objects - CellularTextObject, ZipCodeObject  
:heavy_plus_sign: added report's Email settings (see Report|Options... menu, "Email" tab)  
:heavy_plus_sign: added multi-frame TIFF export  
:heavy_plus_sign: added RC4 128-bit encryption in PDF export  
:heavy_plus_sign: added "Visible" flag in the highlight editor. Now the highlight condition may hide the object  
:heavy_plus_sign: added TextObject's AutoShrink, AutoShrinkMinSize properties  
:heavy_plus_sign: added DataBand's RowCount property  
:heavy_plus_sign: added ReportPage.ManualBuild event  
:heavy_plus_sign: added PictureObject.Angle property  
:heavy_plus_sign: added CommandTimeout property to all connections  
:heavy_plus_sign: added export of watermarks in HTML format  
:heavy_plus_sign: added export of underlined TextObject (Underlines = true) in PDF format  
:heavy_plus_sign: added Swedish, Chinese (Traditional), Czech, Turkish, Spanish localizations  
:heavy_plus_sign: added new demo reports in the "Report Objects" category  
:heavy_plus_sign: added new demo projects in the Demos folder  
:heavy_plus_sign: added AfterData event to all report objects  
:hammer: fixed bug in VB.Net report language  
:hammer: fixed bug in Viewer.exe (exception if window is too small)  
:hammer: fixed bug with selecting Report in the ReportTree in VS design-mode  
:hammer: fixed bug when using WebReport with MasterPage  
:hammer: fixed bug with RTL in HTML export and WebReport  
:hammer: fixed bug with RTL in RichText(rtf) export  
:hammer: fixed bug in MS Chart (border width is not scaled properly when printing)  
:hammer: fixed bug with preview window's "Search" dialog  
:hammer: fixed bug in PDF export when exporting complex fills  
:hammer: fixed bug with export different frame styles in XML and RichText formats  
:hammer: fixed bug when editing prepared report  
:hammer: fixed printing of CellularTextObject  
:hammer: fixed bug with dialogue form  
:hammer: fixed bug with Entity Framework in ASP.NET mode  
:hammer: fixed bug in PageSetup dialog in preview  
:hammer: fixed bug with rendering side-by-side Matrix objects  
:hammer: fixed bug with Nullable<T> column type  
:hammer: fixed bug in Label wizard  
:hammer: fixed bug with send email via MAPI  
:heavy_minus_sign: improvements in hierarchical reports (header/footers, totals)  
:heavy_minus_sign: changes in Matrix object  
:heavy_minus_sign: changes in Excel(XML) export - added export of numeric values  
:heavy_minus_sign: you can use Anchor property of report objects when printing hierarchical bands  
:heavy_minus_sign: changed default extension of resulting file in Excel(XML) export from *.xls to *.xml  
:heavy_minus_sign: pOSSIBLE BREAKING CHANGE! changes in the business objects engine. See details here:http://www.fast-report.com/en/forum/index.php?showtopic=5695  
:heavy_minus_sign: improved performance (loading and running reports with lot of objects)  

## Version 1.1

### [Common]
:heavy_plus_sign: added new UI styles - Office2007Blue, Office2007Silver, Office2007Black, VistaGlass. You can choose the designer and the preview form appearance using the EnvironmentSettings component (its UIStyle property)  
:heavy_plus_sign: added CSV export  
:heavy_plus_sign: added Text/Dot-matrix export  
:heavy_plus_sign: added Designer.exe and Viewer.exe end-user applications  
:heavy_plus_sign: added DesignerControl control  
:heavy_plus_sign: added the "Format Painter" command to the standard toolbar  
:heavy_plus_sign: added two new system variables - "TotalPage#" and "Page#"  
:heavy_plus_sign: added design-time support for BindingSource  
:heavy_plus_sign: added the property "RTFExport.ImageFormat"  
:heavy_plus_sign: added HideIfNoData, NoDataText properties to BarcodeObject  
:heavy_plus_sign: added new demo project - MdiDesigner  
:heavy_plus_sign: added "Table/Fit Dynamic Table To Page" report  
:heavy_plus_sign: added "Dialogs/Cascaded Data Filtering" report  
:heavy_plus_sign: added "Interactive Reports/Interactive Matrix With Chart" report  
:heavy_plus_sign: added "Dialogs/Labels With Dialog" report  
:heavy_plus_sign: added Chinese (simplified) localization  
:heavy_plus_sign: added Arabic localization  
:heavy_plus_sign: added export of transparent colors and pictures (alpha blending) in PDF format  
:heavy_plus_sign: added export of lines, arrows, rectangle shapes, shadows in PDF format  
:heavy_plus_sign: added export of page watermarks in PDF format  
:heavy_plus_sign: added export of dash-dot patterns in PDF format  
:heavy_plus_sign: added export of horizontal and vertical lines, rectangle shapes, shadows in Excel(xml), RichText, OpenOffice and HTML formats  
:hammer: fixed focus lost when closing the preview window  
:hammer: fixed error with text justification  
:hammer: fixed error in data window (when you pass bad DataRelation object)  
:hammer: fixed bug in VS IDE (designer silently closes after you close the preview)  
:hammer: fixed bug with clipboard keys in TextObject in-place edit mode  
:hammer: fixed bug with MS SQL guid-type parameter  
:hammer: fix in business objects processing  
:hammer: fixed bug with subreport's PrintOnParent  
:hammer: fixed issue with printing static & dynamic TableObjects on the same band  
:hammer: fixed bug with report parameters  
:hammer: fixed bug with SQL parameters  
:hammer: fixed duplicate table names issue  
:hammer: fixed TableRow, TableColumn "Visible" property  
:hammer: fixed Matrix "Count" function  
:hammer: fixed bug with TableObject break  
:hammer: fixed bug with relations and empty data columns  
:hammer: fixed rotation of text in Excel(xml), RichText, OpenOffice, HTML and PDF export  
:hammer: fixed bug with subreport and "RepeatOnEveryPage" flag  
:hammer: fixed bug with inserting items of "generic" data type from "Data" window to a script  
:hammer: fixed bug with incorrect escaping of "Script" node content in the .frx file  
:hammer: fixed bug with delays in the designer when selecting a lot of objects  
:hammer: fixed bug with PictureObject.Tile  
:hammer: fixed bug with page breaks and margins in XML export  
:hammer: fixed bug with export of different border lines in Excel(xml), RichText, OpenOffice, HTML and PDF export  
:hammer: fixed bug with underlined and strikeout text in PDF export  
:hammer: fixed bug in PDF export with right border of table object  
:hammer: fixed bug with borders of TableObject in PDF export  
:hammer: fixed bug with creating an event handler for multiple selected objects  
:hammer: fixed bug with subreport & breaked band  
:hammer: fixed bug with designer in Vista 64-bit  
:hammer: fixed Matrix object bug (break spanned cell)  
:hammer: fixed bug with document title in PDF export  
:heavy_minus_sign: enhanced support of Unicode in PDF export  
:heavy_minus_sign: mSChart object moved to main FastReport.dll, no need to plug-in it anymore  
:heavy_minus_sign: fastReport.Dock library now replaced with FastReport.Bars  
