<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaoCaoLuongTon
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDieuKien = New System.Windows.Forms.TextBox()
        Me.dgvDanhSachKhachHang = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSoTienNo = New System.Windows.Forms.TextBox()
        CType(Me.dgvDanhSachKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Số tiền nợ >"
        '
        'txtDieuKien
        '
        Me.txtDieuKien.Location = New System.Drawing.Point(221, 14)
        Me.txtDieuKien.Name = "txtDieuKien"
        Me.txtDieuKien.Size = New System.Drawing.Size(157, 20)
        Me.txtDieuKien.TabIndex = 1
        '
        'dgvDanhSachKhachHang
        '
        Me.dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachKhachHang.Location = New System.Drawing.Point(12, 40)
        Me.dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang"
        Me.dgvDanhSachKhachHang.Size = New System.Drawing.Size(555, 171)
        Me.dgvDanhSachKhachHang.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã khách hàng:"
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.Enabled = False
        Me.txtMaKhachHang.Location = New System.Drawing.Point(221, 227)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.Size = New System.Drawing.Size(157, 20)
        Me.txtMaKhachHang.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Họ tên:"
        '
        'txtHoTen
        '
        Me.txtHoTen.Enabled = False
        Me.txtHoTen.Location = New System.Drawing.Point(221, 253)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(157, 20)
        Me.txtHoTen.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(130, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Điện thoại:"
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Enabled = False
        Me.txtDienThoai.Location = New System.Drawing.Point(221, 279)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(157, 20)
        Me.txtDienThoai.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(221, 305)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(157, 20)
        Me.txtEmail.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(130, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Địa chỉ:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Enabled = False
        Me.txtDiaChi.Location = New System.Drawing.Point(221, 331)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(157, 20)
        Me.txtDiaChi.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(130, 364)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Số tiền nợ:"
        '
        'txtSoTienNo
        '
        Me.txtSoTienNo.Enabled = False
        Me.txtSoTienNo.Location = New System.Drawing.Point(221, 357)
        Me.txtSoTienNo.Name = "txtSoTienNo"
        Me.txtSoTienNo.Size = New System.Drawing.Size(157, 20)
        Me.txtSoTienNo.TabIndex = 1
        '
        'frmBaoCaoLuongTon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 396)
        Me.Controls.Add(Me.dgvDanhSachKhachHang)
        Me.Controls.Add(Me.txtSoTienNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaKhachHang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDieuKien)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBaoCaoLuongTon"
        Me.Text = "BÁO CÁO CÔNG NỢ"
        CType(Me.dgvDanhSachKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDieuKien As TextBox
    Friend WithEvents dgvDanhSachKhachHang As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaKhachHang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSoTienNo As TextBox
End Class
