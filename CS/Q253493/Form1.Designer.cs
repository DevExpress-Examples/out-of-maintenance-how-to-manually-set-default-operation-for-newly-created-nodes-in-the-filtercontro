namespace Q253493 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.filterControl = new Q253493.FilterControl.CustomFilterControl();
            this.persistentRepository1 = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.textEditor = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.spinEditor = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // filterControl
            // 
            this.filterControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl.Location = new System.Drawing.Point(0, 0);
            this.filterControl.Name = "filterControl";
            this.filterControl.Size = new System.Drawing.Size(292, 268);
            this.filterControl.TabIndex = 0;
            this.filterControl.Text = "filterControl1";
            this.filterControl.GetDefaultOperation += new System.EventHandler<Q253493.FilterControl.GetDefaultOperationEventArgs>(OnGetDefaultOperation);
            // 
            // persistentRepository1
            // 
            this.persistentRepository1.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.textEditor,
            this.spinEditor});
            // 
            // textEditor
            // 
            this.textEditor.Name = "textEditor";
            // 
            // spinEditor
            // 
            this.spinEditor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditor.Name = "spinEditor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 268);
            this.Controls.Add(this.filterControl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.textEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Q253493.FilterControl.CustomFilterControl filterControl;
        private DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditor;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinEditor;
    }
}

