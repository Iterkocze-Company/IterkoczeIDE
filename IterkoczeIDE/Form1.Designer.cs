
namespace IterkoczeIDE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Code = new FastColoredTextBoxNS.FastColoredTextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kompilatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kompilujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kompilujIUruchomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.interpretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Code)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Code
            // 
            this.Code.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.Code.AutoIndent = false;
            this.Code.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.Code.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.Code.BackBrush = null;
            this.Code.BackColor = System.Drawing.Color.Silver;
            this.Code.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.Code.CharHeight = 14;
            this.Code.CharWidth = 8;
            this.Code.CommentPrefix = "--";
            this.Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Code.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Code.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Code.Hotkeys = resources.GetString("Code.Hotkeys");
            this.Code.IsReplaceMode = false;
            this.Code.Language = FastColoredTextBoxNS.Language.Lua;
            this.Code.LeftBracket = '(';
            this.Code.LeftBracket2 = '{';
            this.Code.Location = new System.Drawing.Point(0, 24);
            this.Code.Name = "Code";
            this.Code.Paddings = new System.Windows.Forms.Padding(0);
            this.Code.RightBracket = ')';
            this.Code.RightBracket2 = '}';
            this.Code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Code.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("Code.ServiceColors")));
            this.Code.Size = new System.Drawing.Size(800, 426);
            this.Code.TabIndex = 0;
            this.Code.Zoom = 100;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.kompilatorToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.plikToolStripMenuItem.Text = "&File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.newFileToolStripMenuItem.Text = "&New file";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.openFileToolStripMenuItem.Text = "&Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // kompilatorToolStripMenuItem
            // 
            this.kompilatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kompilujToolStripMenuItem,
            this.kompilujIUruchomToolStripMenuItem,
            this.toolStripSeparator1,
            this.interpretToolStripMenuItem});
            this.kompilatorToolStripMenuItem.Name = "kompilatorToolStripMenuItem";
            this.kompilatorToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.kompilatorToolStripMenuItem.Text = "&Compiler";
            // 
            // kompilujToolStripMenuItem
            // 
            this.kompilujToolStripMenuItem.Name = "kompilujToolStripMenuItem";
            this.kompilujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kompilujToolStripMenuItem.Text = "C&ompile";
            this.kompilujToolStripMenuItem.Click += new System.EventHandler(this.kompilujToolStripMenuItem_Click);
            // 
            // kompilujIUruchomToolStripMenuItem
            // 
            this.kompilujIUruchomToolStripMenuItem.Name = "kompilujIUruchomToolStripMenuItem";
            this.kompilujIUruchomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kompilujIUruchomToolStripMenuItem.Text = "Compile and &run";
            this.kompilujIUruchomToolStripMenuItem.Click += new System.EventHandler(this.kompilujIUruchomToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // interpretToolStripMenuItem
            // 
            this.interpretToolStripMenuItem.Name = "interpretToolStripMenuItem";
            this.interpretToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.interpretToolStripMenuItem.Text = "&Interpret";
            this.interpretToolStripMenuItem.Click += new System.EventHandler(this.interpretToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Iterkocze IDE";
            ((System.ComponentModel.ISupportInitialize)(this.Code)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox Code;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kompilatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kompilujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kompilujIUruchomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem interpretToolStripMenuItem;
    }
}

