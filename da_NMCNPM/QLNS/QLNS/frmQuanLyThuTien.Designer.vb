<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyThuTien
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
        Me.cbKhachHang = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSachPhieu = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaPhieuThuTien = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSoTienThu = New System.Windows.Forms.TextBox()
        Me.dtpNgayThuTien = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvDanhSachPhieu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbKhachHang
        '
        Me.cbKhachHang.FormattingEnabled = True
        Me.cbKhachHang.Location = New System.Drawing.Point(139, 12)
        Me.cbKhachHang.Name = "cbKhachHang"
        Me.cbKhachHang.Size = New System.Drawing.Size(190, 21)
        Me.cbKhachHang.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Khách hàng:"
        '
        'dgvDanhSachPhieu
        '
        Me.dgvDanhSachPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhieu.Location = New System.Drawing.Point(12, 39)
        Me.dgvDanhSachPhieu.Name = "dgvDanhSachPhieu"
        Me.dgvDanhSachPhieu.Size = New System.Drawing.Size(447, 150)
        Me.dgvDanhSachPhieu.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mã phiếu thu tiền:"
        '
        'txtMaPhieuThuTien
        '
        Me.txtMaPhieuThuTien.Location = New System.Drawing.Point(207, 215)
        Me.txtMaPhieuThuTien.Name = "txtMaPhieuThuTien"
        Me.txtMaPhieuThuTien.Size = New System.Drawing.Size(141, 20)
        Me.txtMaPhieuThuTien.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ngày thu tiền:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Số tiền thu:"
        '
        'txtSoTienThu
        '
        Me.txtSoTienThu.Location = New System.Drawing.Point(207, 267)
        Me.txtSoTienThu.Name = "txtSoTienThu"
        Me.txtSoTienThu.Size = New System.Drawing.Size(141, 20)
        Me.txtSoTienThu.TabIndex = 4
        '
        'dtpNgayThuTien
        '
        Me.dtpNgayThuTien.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayThuTien.Location = New System.Drawing.Point(207, 241)
        Me.dtpNgayThuTien.Name = "dtpNgayThuTien"
        Me.dtpNgayThuTien.Size = New System.Drawing.Size(141, 20)
        Me.dtpNgayThuTien.TabIndex = 5
        '
        'frmQuanLyThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 336)
        Me.Controls.Add(Me.dtpNgayThuTien)
        Me.Controls.Add(Me.txtSoTienThu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaPhieuThuTien)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDanhSachPhieu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbKhachHang)
        Me.Name = "frmQuanLyThuTien"
        Me.Text = "frmQuanLyThuTien"
        CType(Me.dgvDanhSachPhieu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbKhachHang As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachPhieu As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaPhieuThuTien As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSoTienThu As TextBox
    Friend WithEvents dtpNgayThuTien As DateTimePicker
End Class
