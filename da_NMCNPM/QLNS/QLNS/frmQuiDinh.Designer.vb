<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuiDinh
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
        Me.txtSoLuongNhapItNhat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDieuKienSoLuongNhap = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDieuKienTienNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDieuKienSoLuongBan = New System.Windows.Forms.TextBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.cbDieuKienTienThu = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Số lượng nhập ít nhất:"
        '
        'txtSoLuongNhapItNhat
        '
        Me.txtSoLuongNhapItNhat.Location = New System.Drawing.Point(213, 30)
        Me.txtSoLuongNhapItNhat.Name = "txtSoLuongNhapItNhat"
        Me.txtSoLuongNhapItNhat.Size = New System.Drawing.Size(133, 20)
        Me.txtSoLuongNhapItNhat.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Điều kiện số lượng nhập:"
        '
        'txtDieuKienSoLuongNhap
        '
        Me.txtDieuKienSoLuongNhap.Location = New System.Drawing.Point(213, 56)
        Me.txtDieuKienSoLuongNhap.Name = "txtDieuKienSoLuongNhap"
        Me.txtDieuKienSoLuongNhap.Size = New System.Drawing.Size(133, 20)
        Me.txtDieuKienSoLuongNhap.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Điều kiện tiền nợ:"
        '
        'txtDieuKienTienNo
        '
        Me.txtDieuKienTienNo.Location = New System.Drawing.Point(213, 82)
        Me.txtDieuKienTienNo.Name = "txtDieuKienTienNo"
        Me.txtDieuKienTienNo.Size = New System.Drawing.Size(133, 20)
        Me.txtDieuKienTienNo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Điều kiện số lượng bán:"
        '
        'txtDieuKienSoLuongBan
        '
        Me.txtDieuKienSoLuongBan.Location = New System.Drawing.Point(213, 108)
        Me.txtDieuKienSoLuongBan.Name = "txtDieuKienSoLuongBan"
        Me.txtDieuKienSoLuongBan.Size = New System.Drawing.Size(133, 20)
        Me.txtDieuKienSoLuongBan.TabIndex = 2
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(185, 167)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(77, 28)
        Me.btnCapNhat.TabIndex = 3
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'cbDieuKienTienThu
        '
        Me.cbDieuKienTienThu.AutoSize = True
        Me.cbDieuKienTienThu.Location = New System.Drawing.Point(83, 134)
        Me.cbDieuKienTienThu.Name = "cbDieuKienTienThu"
        Me.cbDieuKienTienThu.Size = New System.Drawing.Size(292, 17)
        Me.cbDieuKienTienThu.TabIndex = 6
        Me.cbDieuKienTienThu.Text = "Số tiền thu không vượt quá số tiền khách hàng đang nợ"
        Me.cbDieuKienTienThu.UseVisualStyleBackColor = True
        '
        'frmQuiDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 224)
        Me.Controls.Add(Me.cbDieuKienTienThu)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtDieuKienSoLuongBan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDieuKienTienNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDieuKienSoLuongNhap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSoLuongNhapItNhat)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQuiDinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUI ĐỊNH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSoLuongNhapItNhat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDieuKienSoLuongNhap As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDieuKienTienNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDieuKienSoLuongBan As TextBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents cbDieuKienTienThu As CheckBox
End Class
