<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraCuu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTraCuu))
        Me.dgvDanhSachSach = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPhuongThuc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTheLoai = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgvDanhSachSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDanhSachSach
        '
        Me.dgvDanhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachSach.Location = New System.Drawing.Point(15, 65)
        Me.dgvDanhSachSach.Name = "dgvDanhSachSach"
        Me.dgvDanhSachSach.Size = New System.Drawing.Size(617, 191)
        Me.dgvDanhSachSach.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Phương thức:"
        '
        'cbPhuongThuc
        '
        Me.cbPhuongThuc.FormattingEnabled = True
        Me.cbPhuongThuc.Location = New System.Drawing.Point(261, 12)
        Me.cbPhuongThuc.Name = "cbPhuongThuc"
        Me.cbPhuongThuc.Size = New System.Drawing.Size(173, 21)
        Me.cbPhuongThuc.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tìm kiếm:"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtTimKiem.Location = New System.Drawing.Point(70, 39)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(529, 20)
        Me.txtTimKiem.TabIndex = 4
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Image = CType(resources.GetObject("btnTimKiem.Image"), System.Drawing.Image)
        Me.btnTimKiem.Location = New System.Drawing.Point(605, 37)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(27, 23)
        Me.btnTimKiem.TabIndex = 5
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mã sách:"
        '
        'txtMaSach
        '
        Me.txtMaSach.Enabled = False
        Me.txtMaSach.Location = New System.Drawing.Point(224, 286)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(199, 20)
        Me.txtMaSach.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tên sách:"
        '
        'txtTenSach
        '
        Me.txtTenSach.Enabled = False
        Me.txtTenSach.Location = New System.Drawing.Point(224, 312)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(199, 20)
        Me.txtTenSach.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(167, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Thể loại:"
        '
        'txtTheLoai
        '
        Me.txtTheLoai.Enabled = False
        Me.txtTheLoai.Location = New System.Drawing.Point(224, 338)
        Me.txtTheLoai.Name = "txtTheLoai"
        Me.txtTheLoai.Size = New System.Drawing.Size(199, 20)
        Me.txtTheLoai.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(167, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tác giả:"
        '
        'txtTacGia
        '
        Me.txtTacGia.Enabled = False
        Me.txtTacGia.Location = New System.Drawing.Point(224, 364)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(199, 20)
        Me.txtTacGia.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(167, 397)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Đơn giá:"
        '
        'txtDonGia
        '
        Me.txtDonGia.Enabled = False
        Me.txtDonGia.Location = New System.Drawing.Point(224, 390)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(199, 20)
        Me.txtDonGia.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(167, 423)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Số lượng:"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Enabled = False
        Me.txtSoLuong.Location = New System.Drawing.Point(224, 416)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(199, 20)
        Me.txtSoLuong.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(259, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "THÔNG TIN SÁCH"
        '
        'frmTraCuu
        '
        Me.AcceptButton = Me.btnTimKiem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 461)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTacGia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTheLoai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTenSach)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbPhuongThuc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDanhSachSach)
        Me.Name = "frmTraCuu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRA CỨU"
        CType(Me.dgvDanhSachSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDanhSachSach As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cbPhuongThuc As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTheLoai As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTacGia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents Label9 As Label
End Class
