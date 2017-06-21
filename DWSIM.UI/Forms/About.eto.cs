﻿using Eto.Forms;
using Eto.Drawing;
using System.Reflection;
using System.IO;

namespace DWSIM.UI.Forms
{
    partial class About : Form
    {
        void InitializeComponent()
        {

            Title = "About";

            string imgprefix = "DWSIM.UI.Forms.Resources.Icons.";

            var layout = new PixelLayout();

            string vtext = "Version " + Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();
            string crtext = Shared.AssemblyCopyright;

            layout.Add(new ImageView {Width = 100, Height = 100, Image = new Bitmap(Eto.Drawing.Bitmap.FromResource(imgprefix + "DWSIM_ico.png")) }, 10, 10);
            layout.Add(new Label { Text = "DWSIM Simulator", TextAlignment = TextAlignment.Left, Font = SystemFonts.Bold(null, FontDecoration.None) }, 120, 10);
            layout.Add(new Label { Text = vtext, TextAlignment = TextAlignment.Left, Font = SystemFonts.Bold(null, FontDecoration.None) }, 120, 30);
            layout.Add(new Label { Text = crtext, TextAlignment = TextAlignment.Left, Font = SystemFonts.Bold(null, FontDecoration.None) }, 120, 50);

            string gpltext;
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("DWSIM.UI.Forms.Resources.TextFiles.gpl-3.0.txt"))
            using (StreamReader reader = new StreamReader(stream))
            {
                gpltext = reader.ReadToEnd();
            }

            var textbox = new TextArea { Text = gpltext, Width = 480, Height = 420, ReadOnly = true};

            layout.Add(textbox, 10, 120);

            var okbutton = new Button { Text = "OK" };

            okbutton.Click += (sender, e) => Close();

            layout.Add(okbutton, 420, 600 - 55);

            Width = 500;
            Height = 600;

            layout.Width = Width;
            layout.Height = Height;
            
            Content = layout;
            
        }
    }
}
