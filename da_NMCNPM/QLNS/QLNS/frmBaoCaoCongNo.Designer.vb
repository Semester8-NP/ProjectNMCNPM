<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBaoCaoCongNo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtSoTienDieuKien = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSachSach = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTheLoai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        CType(Me.dgvDanhSachSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSoTienDieuKien
        '
        Me.txtSoTienDieuKien.Location = New System.Drawing.Point(241, 15)
        Me.txtSoTienDieuKien.Name = "txtSoTienDieuKien"
        Me.txtSoTienDieuKien.Size = New System.Drawing.Size(146, 20)
        Me.txtSoTienDieuKien.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Số lượng sách > "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDanhSachSach
        '
        Me.dgvDanhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachSach.Location = New System.Drawing.Point(12, 41)
        Me.dgvDanhSachSach.Name = "dgvDanhSachSach"
        Me.dgvDanhSachSach.Size = New System.Drawing.Size(606, 146)
        Me.dgvDanhSachSach.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mã sách:"
        '
        'txtMaSach
        '
        Me.txtMaSach.Enabled = False
        Me.txtMaSach.Location = New System.Drawing.Point(215, 210)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(172, 20)
        Me.txtMaSach.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tên sách:"
        '
        'txtTenSach
        '
        Me.txtTenSach.Enabled = False
        Me.txtTenSach.Location = New System.Drawing.Point(215, 236)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(172, 20)
        Me.txtTenSach.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Thể loại:"
        '
        'txtTheLoai
        '
        Me.txtTheLoai.Enabled = False
        Me.txtTheLoai.Location = New System.Drawing.Point(215, 262)
        Me.txtTheLoai.Name = "txtTheLoai"
        Me.txtTheLoai.Size = New System.Drawing.Size(172, 20)
        Me.txtTheLoai.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tác giả:"
        '
        'txtTacGia
        '
        Me.txtTacGia.Enabled = False
        Me.txtTacGia.Location = New System.Drawing.Point(215, 288)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(172, 20)
        Me.txtTacGia.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(148, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Số lượng:"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Enabled = False
        Me.txtSoLuong.Location = New System.Drawing.Point(215, 314)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(172, 20)
        Me.txtSoLuong.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(148, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Đơn giá:"
        '
        'txtDonGia
        '
        Me.txtDonGia.Enabled = False
        Me.txtDonGia.Location = New System.Drawing.Point(215, 340)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(172, 20)
        Me.txtDonGia.TabIndex = 5
        '
        'frmBaoCaoCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 385)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTacGia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTheLoai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTenSach)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDanhSachSach)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSoTienDieuKien)
        Me.Name = "frmBaoCaoCongNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BÁO CÁO SÁCH TỒN"
        CType(Me.dgvDanhSachSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSoTienDieuKien As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachSach As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTheLoai As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTacGia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDonGia As TextBox
End Class
