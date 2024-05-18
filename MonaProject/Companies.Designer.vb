<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Companies
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Companies))
        Me.DGVcom = New System.Windows.Forms.DataGridView()
        Me.btnTrainers = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.DGVcom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVcom
        '
        Me.DGVcom.AllowUserToAddRows = False
        Me.DGVcom.AllowUserToDeleteRows = False
        Me.DGVcom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVcom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcom.Location = New System.Drawing.Point(12, 43)
        Me.DGVcom.Name = "DGVcom"
        Me.DGVcom.ReadOnly = True
        Me.DGVcom.Size = New System.Drawing.Size(712, 357)
        Me.DGVcom.TabIndex = 21
        '
        'btnTrainers
        '
        Me.btnTrainers.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrainers.Image = CType(resources.GetObject("btnTrainers.Image"), System.Drawing.Image)
        Me.btnTrainers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrainers.Location = New System.Drawing.Point(565, 11)
        Me.btnTrainers.Name = "btnTrainers"
        Me.btnTrainers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnTrainers.Size = New System.Drawing.Size(122, 29)
        Me.btnTrainers.TabIndex = 25
        Me.btnTrainers.Text = "قائمة المدربين"
        Me.btnTrainers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTrainers.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(479, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(64, 29)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "بحث"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(178, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(295, 23)
        Me.TextBox1.TabIndex = 23
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(78, 11)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(68, 29)
        Me.btnBack.TabIndex = 22
        Me.btnBack.Text = "رجوع"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Companies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(736, 410)
        Me.Controls.Add(Me.DGVcom)
        Me.Controls.Add(Me.btnTrainers)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Companies"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "قائمة الشركات"
        CType(Me.DGVcom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVcom As System.Windows.Forms.DataGridView
    Public WithEvents btnTrainers As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
