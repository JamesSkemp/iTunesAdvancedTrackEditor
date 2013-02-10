namespace JamesRSkemp.iTunes.AdvancedTrackEditor
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelConnection = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelTracks = new System.Windows.Forms.ToolStripStatusLabel();
			this.panelEditor = new System.Windows.Forms.Panel();
			this.dataGridViewTracks = new System.Windows.Forms.DataGridView();
			this.comboBoxPlaylists = new System.Windows.Forms.ComboBox();
			this.textBoxSearchTerms = new System.Windows.Forms.TextBox();
			this.labelSearchTerms = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panelConnection = new System.Windows.Forms.Panel();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.panelEditor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracks)).BeginInit();
			this.panelConnection.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConnection,
            this.toolStripStatusLabelTracks});
			this.statusStrip1.Location = new System.Drawing.Point(0, 271);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(521, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabelConnection
			// 
			this.toolStripStatusLabelConnection.Name = "toolStripStatusLabelConnection";
			this.toolStripStatusLabelConnection.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabelTracks
			// 
			this.toolStripStatusLabelTracks.Name = "toolStripStatusLabelTracks";
			this.toolStripStatusLabelTracks.Size = new System.Drawing.Size(0, 17);
			// 
			// panelEditor
			// 
			this.panelEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelEditor.Controls.Add(this.dataGridViewTracks);
			this.panelEditor.Controls.Add(this.comboBoxPlaylists);
			this.panelEditor.Controls.Add(this.textBoxSearchTerms);
			this.panelEditor.Controls.Add(this.labelSearchTerms);
			this.panelEditor.Controls.Add(this.buttonSearch);
			this.panelEditor.Controls.Add(this.label2);
			this.panelEditor.Controls.Add(this.label1);
			this.panelEditor.Location = new System.Drawing.Point(0, 0);
			this.panelEditor.Name = "panelEditor";
			this.panelEditor.Size = new System.Drawing.Size(521, 268);
			this.panelEditor.TabIndex = 3;
			this.panelEditor.Visible = false;
			// 
			// dataGridViewTracks
			// 
			this.dataGridViewTracks.AllowUserToAddRows = false;
			this.dataGridViewTracks.AllowUserToDeleteRows = false;
			this.dataGridViewTracks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTracks.Location = new System.Drawing.Point(12, 38);
			this.dataGridViewTracks.Name = "dataGridViewTracks";
			this.dataGridViewTracks.Size = new System.Drawing.Size(497, 227);
			this.dataGridViewTracks.TabIndex = 5;
			this.dataGridViewTracks.Visible = false;
			// 
			// comboBoxPlaylists
			// 
			this.comboBoxPlaylists.FormattingEnabled = true;
			this.comboBoxPlaylists.Location = new System.Drawing.Point(57, 11);
			this.comboBoxPlaylists.Name = "comboBoxPlaylists";
			this.comboBoxPlaylists.Size = new System.Drawing.Size(121, 21);
			this.comboBoxPlaylists.TabIndex = 1;
			this.comboBoxPlaylists.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlaylists_SelectedIndexChanged);
			// 
			// textBoxSearchTerms
			// 
			this.textBoxSearchTerms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSearchTerms.Location = new System.Drawing.Point(262, 11);
			this.textBoxSearchTerms.Name = "textBoxSearchTerms";
			this.textBoxSearchTerms.Size = new System.Drawing.Size(188, 20);
			this.textBoxSearchTerms.TabIndex = 3;
			// 
			// labelSearchTerms
			// 
			this.labelSearchTerms.AutoSize = true;
			this.labelSearchTerms.Location = new System.Drawing.Point(183, 14);
			this.labelSearchTerms.Name = "labelSearchTerms";
			this.labelSearchTerms.Size = new System.Drawing.Size(73, 13);
			this.labelSearchTerms.TabIndex = 2;
			this.labelSearchTerms.Text = "Search Terms";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSearch.Location = new System.Drawing.Point(456, 9);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(53, 23);
			this.buttonSearch.TabIndex = 4;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Playlist";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// panelConnection
			// 
			this.panelConnection.Controls.Add(this.buttonConnect);
			this.panelConnection.Location = new System.Drawing.Point(0, 0);
			this.panelConnection.Name = "panelConnection";
			this.panelConnection.Size = new System.Drawing.Size(521, 268);
			this.panelConnection.TabIndex = 4;
			// 
			// buttonConnect
			// 
			this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonConnect.Location = new System.Drawing.Point(12, 12);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(497, 44);
			this.buttonConnect.TabIndex = 2;
			this.buttonConnect.Text = "Connect to iTunes";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 293);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.panelEditor);
			this.Controls.Add(this.panelConnection);
			this.MinimumSize = new System.Drawing.Size(450, 300);
			this.Name = "MainForm";
			this.Text = "iTunes Advanced Track Editor";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panelEditor.ResumeLayout(false);
			this.panelEditor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracks)).EndInit();
			this.panelConnection.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnection;
		private System.Windows.Forms.Panel panelEditor;
		private System.Windows.Forms.Panel panelConnection;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTracks;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxSearchTerms;
		private System.Windows.Forms.Label labelSearchTerms;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.ComboBox comboBoxPlaylists;
		private System.Windows.Forms.DataGridView dataGridViewTracks;

	}
}

