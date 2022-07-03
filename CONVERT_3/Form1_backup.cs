using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using CONVERT_3.model;
using System.IO;
using Point = CONVERT_3.model.Point;
using System.Xml.Linq;

namespace CONVERT_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_export_Click(object sender, EventArgs e)   // code chức năng cho nút 
        {
            if (txt_holder.Text.Equals("") || txt_tool.Text.Equals("") || txt_setup.Text.Equals(""))
            {
                MessageBox.Show("Input is missing");
                return;
            }
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "XML file (*.xml)|*.xml";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Where do you want to save the file?";
            saveFileDialog1.InitialDirectory = @"C:/";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                
            {

                export(saveFileDialog1.FileName);

                try
                {
                   

                }
                catch
                {
                    MessageBox.Show("Incorrect input");

                }
            }
            else
            {
                MessageBox.Show("You hit cancel or closed the dialog.");
            }
            saveFileDialog1.Dispose();
        }
       
        private void export(String fileName)    // code nút export , chuyển Csv 
        {         
            List<Tool> ToolList = null;
            try
            {
                ToolList = ReadReportToolExcel(); 

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            XElement top = new XElement("CGTechToolLibrary",new XAttribute("Version","7.2"),
                new XElement("Tools",
                    from tool in ToolList
                    select new XElement("Tool", new XAttribute("Units", "Millimeter"), new XAttribute("ID", tool.ID),
                         new XElement("Description", tool.Comment),
                         new XElement("Comments"),
                         new XElement("Teeth", tool.Teeth),
                         new XElement("Type", tool.Tech),
                         new XElement("Cutter",

                             new XElement("Apt", new XAttribute("ID", tool.CutterName), new XAttribute("Type", tool.Type),
                                  new XElement("D", tool.Diameter),
                                  new XElement("R", tool.CornerRadius),
                                  new XElement("E", 0),
                                  new XElement("F", 0),
                                  new XElement("A", 0),
                                  new XElement("B", 0),
                                  new XElement("H", tool.ClearLength),
                                  new XElement("R2", 0),
                                  new XElement("E2", 0),
                                  new XElement("F2", 0),
                                  new XElement("SpindleDirection", "CW"),
                                  new XElement("FluteLength", tool.ClearLength),
                                  new XElement("SharkDiameter", tool.Diameter)
                                               )
                                             ),

                         new XElement("Holder",
                              new XElement("SOR", new XAttribute("ID", tool.HolderName), from p in tool.holder.Points
                                                                                         select new XElement("Pt",
                                                                                                     new XElement("X", p.x),
                                                                                                     new XElement("Z", p.z)
                                                                                                ),
                                                         new XElement("Origin",
                                                              new XElement("X", 0),
                                                              new XElement("Y", 0),
                                                              new XElement("Z", tool.ClearLength))

                                           )

             ),
                          new XElement("GagePoint",
                             new XElement("X", 0),
                             new XElement("Y", 0),
                             new XElement("Z", tool.holder.Height + +float.Parse(tool.ClearLength))),
                         new XElement("DrivenPoint", new XAttribute("ID", tool.ID),
                             new XElement("Type", -1),
                             new XElement("X", 0),
                             new XElement("Y", 0),
                             new XElement("Z", 0))

            )));
            // var utf8WithoutBom = new System.Text.UTF8Encoding(false);
            //  File.WriteAllText(fileName,"abc", utf8WithoutBom);

            // Encoding utf8WithoutBom = new UTF8Encoding(true);
            //  TextWriter tw = new StreamWriter(fileName, false, utf8WithoutBom);
            // foreach (XElement s in top.Elements())
            //     tw.WriteLine(s);
            // tw.Close();
           // UTF8Encoding utf = new UTF8Encoding(false);
           // StreamWriter sw = new StreamWriter(Path.Combine((string)top, fileName),false, utf);
            //sw.Close();
          top.Save(fileName);
          System.Diagnostics.Process.Start(fileName);

        }
        // đọc file excel
        public List<Tool> ReadReportToolExcel()     // Tạo list gồm các  thông số của từng ID , gồm nhiều ID
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            List<Tool> setuplist = new List<Tool>();
            ExcelPackage package = new ExcelPackage(new FileInfo(txt_setup.Text));
            ExcelWorksheet worksheet = package.Workbook.Worksheets.First();

            int rowCount = worksheet.Dimension.Rows;
            int row;
          
            bool isExistProramTools = false;
            for (row = 1; row < rowCount; row++)
            {
                if (worksheet.Cells[row, 2].Value?.ToString().Trim() == "Program tools") {
                    isExistProramTools = true;
                    break;// Lấy hàng của Program Tools  
                }
            }

            if(!isExistProramTools){
                Exception myexception = new Exception("Setup.xlsx is incorrect");
                throw myexception;
            }
            row += 2; // Bỏ qua hàng Number
           
            while (worksheet.Cells[row, 2].Value != null)
            {
                var tool = new Tool();
                tool.ID = worksheet.Cells[row, 2].Value?.ToString();
                tool.ID = tool.ID.Remove(0,3);
                tool.CutterName = worksheet.Cells[row, 3].Value?.ToString().Trim();
                tool.Comment = worksheet.Cells[row, 4].Value?.ToString().Trim();
                tool.Diameter = worksheet.Cells[row, 5].Value?.ToString().Trim();
                tool.CornerRadius = worksheet.Cells[row, 6].Value?.ToString().Trim();
                tool.TaperAngle = worksheet.Cells[row, 8].Value?.ToString().Trim();
                tool.CutLength = worksheet.Cells[row, 9].Value?.ToString().Trim();
                tool.ClearLength = worksheet.Cells[row, 10].Value?.ToString().Trim();
                tool.Type = worksheet.Cells[row, 11].Value?.ToString().Trim();
                tool.HolderName = worksheet.Cells[row, 12].Value?.ToString().Trim();
                List<float> holder_parameters = null;
                try
                {
                    holder_parameters = ReadCSVFileHolder(tool.HolderName);
                    tool.holder = get_holder(holder_parameters);
                }
                catch
                {
                    Exception myexception = new Exception("No Holder in Holder.csv");
                    throw myexception;
                }

                try
                {
                    tool.Teeth = get_teeth(tool);
                    if (tool.Teeth.Trim() == "error")
                    {
                        MessageBox.Show("Tool.csv is incorrect");
                        break;
                    }



                }
                catch
                {
                    Exception myexception = new Exception("Tool.csv is incorrect");
                    throw myexception;
                }



                get_tech(tool);
                setuplist.Add(tool);
                row += 1;

            }
            return setuplist;
        }


        // đọc file holder.csv
        private List<float> ReadCSVFileHolder(string HOLDERNAME)
        {

            var lines = File.ReadAllLines(txt_holder.Text);
            List<float> list = new List<float>();
            for (int row = 9; row < lines.Length; row++) // Băt đầu từ hàng thứ 10
            {
                var values = lines[row].Split('|');
                if (values[0] == HOLDERNAME)
                {
                    for (int i = 2; i < values.Length; i++)
                    { // Băt đầu từ thông số Segment No.
                        list.Add(float.Parse(values[i]));
                        
                    }
                    
                }

            }
            return list;
        }



        private Holder get_holder(List<float> plist) // Đưa vào danh sách các thông số của holder,tạo list gồm các tọa độ ,mỗi một ID tao ra một list các điểm 
        {
            Holder holder = new Holder();
            var pl = new List<Point>(); // Danh sách các điểm
            float x = 0, z = 0; // Tọa độ điểm
            pl.Add(new model.Point(x, z)); // Thêm điểm (0, 0)
            for (int i = 0; i < 11; i++)
            {
                if (plist[2 + 4 * i] == 0)  // Khi đường kính = 0
                {
                    if (plist[1] == 1)
                    {
                        plist.RemoveAt(plist.Count - 1);
                        plist.RemoveAt(plist.Count - 1);
                    }
                    break;
                }
                x = plist[2 + 4 * i] / 2;    // x = bán kính
                pl.Add(new Point(x, z));
                x += (plist[3 + 4 * i] - plist[2 + 4 * i]) / 2;
                z += plist[5 + 4 * i];       // z += chiều cao
                pl.Add(new Point(x, z));
            }
            pl.Add(new Point(0, z)); // Thêm điểm (0, height)

            holder.Height = z;  // z = chiều cao holder
            holder.Points = pl; //
            return holder;
        }

        private string get_teeth(Tool tool)// lấy teeth trong từng tool  , cái trong ngoặc là cái dữ liệu đầu vào 
        {
            var lines = File.ReadAllLines(txt_tool.Text);
            string Teeth = "ERROR";
            var c_values = lines[7].Split('|');
            if (c_values[34].Trim() == "Teeth")
            {
                // default = 2
                for (int row = 9; row < lines.Length; row++)
                {
                    var values = lines[row].Split('|');
                    if (values[0].Trim() == tool.CutterName) Teeth = values[34];
                }

            }
            else { Teeth = "error"; }
           
            return Teeth;

        }

        private void get_tech(Tool tool)
        {
            var lines = File.ReadAllLines(txt_tool.Text);
            tool.Technology = "";
            for (int row = 9; row < lines.Length; row++)
            {
                var values = lines[row].Split('|');
                if (values[0].Trim() == tool.CutterName) tool.Technology = values[6];
            }
            tool.Tech = tool.getTechnology();
        }

        private void btn_setup_Click(object sender, EventArgs e)   // code nút setup
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get setup file";
            fdlg.Filter = "xlsx files (*.xlsx)|*.xlsx";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txt_setup.Text = fdlg.FileName;
            }
            
        }

        private void btn_holder_Click_1(object sender, EventArgs e)   // tạo nút holder 
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get holder file";
            fdlg.Filter = "CSV files (*.csv)|*.csv";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txt_holder.Text = fdlg.FileName;
            }
        }

        private void btn_tool_Click_1(object sender, EventArgs e) // code nút tool 
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get tool file";
            fdlg.Filter = "CSV files (*.csv)|*.csv";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txt_tool.Text = fdlg.FileName;
            }
        }







        private void ReadToolXlsx(String fileName)    // đọc 
        {
            
            List<Tool2> ToolList2 = null;

            try
            {
                ToolList2 = readtoolexcel();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }


            XElement top = new XElement("CGTechToolLibrary ",

                       new XElement("Tools",
                       from tool2 in ToolList2
                       select


 new XElement("Tool", new XAttribute("Unit", "Millimeter"), new XAttribute("ID", tool2.ID),
   new XElement("Description", tool2.Description),
   new XElement("Comments"),
   new XElement("Teeth", 2),
   new XElement("Type", "Milling"),
   new XElement("Cutter",

       new XElement("Apt", new XAttribute("ID", tool2.CutterName), new XAttribute("Type", tool2.Type),
            new XElement("D", tool2.D),
            new XElement("R", tool2.R),
            new XElement("E", 0),
            new XElement("F", 0),
            new XElement("A", tool2.A),
            new XElement("B", 0),
            new XElement("H", tool2.H),
            new XElement("R2", 0),
            new XElement("E2", 0),
            new XElement("F2", 0),
            new XElement("SpindleDirection", "CW"),
            new XElement("FluteLength", tool2.FluteLength),
            new XElement("SharkDiameter", tool2.SharkDiameter)

                         )
                       ),

   new XElement("Holder",
       new XElement("SOR", new XAttribute("ID", tool2.Holdername), from p in tool2.holder2.Points
                                                                   select new XElement("Pt",
                                                                               new XElement("X", p.x),
                                                                               new XElement("Z", p.z)
                                                                          ),

            new XElement("Origin",
                  new XElement("X", 0),
                   new XElement("Y", 0),
                   new XElement("Z", tool2.H)

                                     )),
  new XElement("GagePoint",
      new XElement("X", 0),
      new XElement("Y", 0),
      new XElement("Z", float.Parse(tool2.H)+ tool2.holder2.Height)),
  new XElement("DrivenPoint", new XAttribute("ID", tool2.ID),
      new XElement("Type", -1),
      new XElement("X", 0),
      new XElement("Y", 0),
      new XElement("Z", 0)))


         )));

            top.Save(fileName);
           
        }
        // Tạo list tool cho file excel 
        public List<Tool2> readtoolexcel()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage package = new ExcelPackage(new FileInfo(txt_toolxlsx.Text));
            ExcelWorksheet Sheet1 = package.Workbook.Worksheets[0];
            List<Tool2> toollistexcel = new List<Tool2>();
            int rows = Sheet1.Dimension.Rows;
            int columns = Sheet1.Dimension.Columns;
            int t = 9;     // tạo các danh sách tham số con 
            int i = 9;
            int r = 9;
            while (Sheet1.Cells[r+8, 2].Value != null) 
            { r = r + 8;
            }
            
                while (i<r)
            {
                Sheet1.Cells[i, 2].Value = i / 8;
                i = i + 8;
            };

            while (t<r)
            { List<float> plist = new List<float>();
                Tool2 tool2 = new Tool2();
                for (int h = t + 3; h < t + 7; h++)
                {
                    for  (int k = 4; k <= 13; k++)
                    {
                        plist.Add(float.Parse(Sheet1.Cells[h, k].Value?.ToString().Trim()));

                    }
                }
                tool2.list = plist;
                tool2.ID = Sheet1.Cells[9 + t - 9, 2].Value?.ToString().Trim();
                tool2.Type = Sheet1.Cells[10 + t - 9, 4].Value?.ToString().Trim();
                tool2.Holdername = Sheet1.Cells[11+t - 9, 2].Value?.ToString().Trim();
                tool2.Description = Sheet1.Cells[10 + t - 9, 5].Value?.ToString().Trim();
                tool2.CutterName =  Sheet1.Cells[10 + t - 9, 3].Value?.ToString().Trim();
                tool2.D = Sheet1.Cells[10 + t - 9, 6].Value?.ToString().Trim();
                tool2.R = Sheet1.Cells[10 + t - 9, 8].Value?.ToString().Trim();
                tool2.A = Sheet1.Cells[10 + t - 9, 10].Value?.ToString().Trim();
                tool2.H = Sheet1.Cells[10 + t - 9, 12].Value?.ToString().Trim();
                tool2.FluteLength =  Sheet1.Cells[10 + t - 9, 12].Value?.ToString().Trim();
                tool2.SharkDiameter = Sheet1.Cells[10 + t - 9, 6].Value?.ToString().Trim();
                tool2.holder2 = get_holderexcel(tool2.list);              // phần này cực kỳ quan trọng , link tool với holder2 để tiện truy suất dữ liệu ở đoạn sau 
                toollistexcel.Add(tool2);
                t = t + 8; 
            }

            return toollistexcel;

        }
        private Holder get_holderexcel(List<float> plist) // Đưa vào danh sách các thông số của holder  , Holder là kiểu đã được định nghĩa sẵn 
        {
            Holder holder2 = new Holder();
            var pl = new List<Point>(); // Danh sách các điểm
            float x = 0, z = 0; // Tọa độ điểm
            pl.Add(new model.Point(x, z)); // Thêm điểm (0, 0)
            for (int i = 0; i < 10; i++)
            {
                if (plist[i] == 0) { if (plist[10 + i] == 0) { break; } }
                x = plist[ i] / 2;    // x = bán kính
                pl.Add(new Point(x, z));
                x = plist[10+i] / 2;    // cho mặc định là 4 vì tối đa 10 điểm 
                z = z+plist[30+i];
                pl.Add(new Point(x, z));
            }
            pl.Add(new Point(0, z)); // Thêm điểm (0, height)

            holder2.Height = z;  // z = chiều cao holder
            holder2.Points = pl; //
            return holder2;
        }





        private void btn_export2_Click(object sender, EventArgs e)
        {
            if (txt_toolxlsx.Text.Equals(""))
            {
                MessageBox.Show("Input is missing");
                return;
            }
            SaveFileDialog saveFileDialog2 = new SaveFileDialog();
            saveFileDialog2.DefaultExt = "txt";
            saveFileDialog2.Filter = "XML file (*.xml)|*.xml";
            saveFileDialog2.AddExtension = true;
            saveFileDialog2.RestoreDirectory = true;
            saveFileDialog2.Title = "Where do you want to save the file?";
            saveFileDialog2.InitialDirectory = @"C:/";
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    ReadToolXlsx(saveFileDialog2.FileName);
                    System.Diagnostics.Process.Start(saveFileDialog2.FileName);

                }
                catch
                {
                    MessageBox.Show("Tool.xlsx is Incorrect");

                }
            }
            else
            {
                MessageBox.Show("You hit cancel or closed the dialog.");
            }
            saveFileDialog2.Dispose();
        }

        private void btn_toolxlsx_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get tool.xlsx file";
            fdlg.Filter = "xlsx files (*.xlsx)|*.xlsx";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txt_toolxlsx.Text = fdlg.FileName;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_toolxlsx_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
