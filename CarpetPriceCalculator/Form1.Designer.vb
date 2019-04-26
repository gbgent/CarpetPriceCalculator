<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gb_CarpetData = New System.Windows.Forms.GroupBox()
        Me.txt_Price = New System.Windows.Forms.TextBox()
        Me.txt_Style = New System.Windows.Forms.TextBox()
        Me.txt_Color = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_Area = New System.Windows.Forms.Label()
        Me.txt_Length = New System.Windows.Forms.TextBox()
        Me.txt_Width = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Cost = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.gb_CarpetData.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_CarpetData
        '
        Me.gb_CarpetData.Controls.Add(Me.txt_Price)
        Me.gb_CarpetData.Controls.Add(Me.txt_Style)
        Me.gb_CarpetData.Controls.Add(Me.txt_Color)
        Me.gb_CarpetData.Controls.Add(Me.Label4)
        Me.gb_CarpetData.Controls.Add(Me.Label3)
        Me.gb_CarpetData.Controls.Add(Me.Label2)
        Me.gb_CarpetData.Controls.Add(Me.Label1)
        Me.gb_CarpetData.Location = New System.Drawing.Point(12, 26)
        Me.gb_CarpetData.Name = "gb_CarpetData"
        Me.gb_CarpetData.Size = New System.Drawing.Size(309, 200)
        Me.gb_CarpetData.TabIndex = 0
        Me.gb_CarpetData.TabStop = False
        Me.gb_CarpetData.Text = "Carpet Data"
        '
        'txt_Price
        '
        Me.txt_Price.Location = New System.Drawing.Point(92, 127)
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(173, 27)
        Me.txt_Price.TabIndex = 6
        '
        'txt_Style
        '
        Me.txt_Style.Location = New System.Drawing.Point(92, 85)
        Me.txt_Style.Name = "txt_Style"
        Me.txt_Style.Size = New System.Drawing.Size(173, 27)
        Me.txt_Style.TabIndex = 5
        '
        'txt_Color
        '
        Me.txt_Color.Location = New System.Drawing.Point(92, 47)
        Me.txt_Color.Name = "txt_Color"
        Me.txt_Color.Size = New System.Drawing.Size(173, 27)
        Me.txt_Color.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "{Per Square Foot}"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Style:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Color:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lbl_Area)
        Me.GroupBox2.Controls.Add(Me.txt_Length)
        Me.GroupBox2.Controls.Add(Me.txt_Width)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(331, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 200)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'lbl_Area
        '
        Me.lbl_Area.BackColor = System.Drawing.Color.Lavender
        Me.lbl_Area.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Area.Location = New System.Drawing.Point(95, 131)
        Me.lbl_Area.Name = "lbl_Area"
        Me.lbl_Area.Size = New System.Drawing.Size(173, 27)
        Me.lbl_Area.TabIndex = 12
        Me.lbl_Area.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Length
        '
        Me.txt_Length.Location = New System.Drawing.Point(95, 85)
        Me.txt_Length.Name = "txt_Length"
        Me.txt_Length.Size = New System.Drawing.Size(173, 27)
        Me.txt_Length.TabIndex = 11
        '
        'txt_Width
        '
        Me.txt_Width.Location = New System.Drawing.Point(95, 47)
        Me.txt_Width.Name = "txt_Width"
        Me.txt_Width.Size = New System.Drawing.Size(173, 27)
        Me.txt_Width.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Area:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Length:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Width:"
        '
        'lbl_Cost
        '
        Me.lbl_Cost.BackColor = System.Drawing.Color.Lavender
        Me.lbl_Cost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Cost.Location = New System.Drawing.Point(269, 267)
        Me.lbl_Cost.Name = "lbl_Cost"
        Me.lbl_Cost.Size = New System.Drawing.Size(173, 27)
        Me.lbl_Cost.TabIndex = 14
        Me.lbl_Cost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(166, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Total Cost:"
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Calculate.Location = New System.Drawing.Point(74, 345)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(122, 49)
        Me.btn_Calculate.TabIndex = 15
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(263, 345)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(122, 49)
        Me.btn_Clear.TabIndex = 16
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(452, 345)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(122, 49)
        Me.btn_Exit.TabIndex = 17
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(652, 447)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.lbl_Cost)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gb_CarpetData)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carpet Price Calculator"
        Me.gb_CarpetData.ResumeLayout(False)
        Me.gb_CarpetData.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gb_CarpetData As GroupBox
    Friend WithEvents txt_Price As TextBox
    Friend WithEvents txt_Style As TextBox
    Friend WithEvents txt_Color As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_Area As Label
    Friend WithEvents txt_Length As TextBox
    Friend WithEvents txt_Width As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_Cost As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_Calculate As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Exit As Button
End Class
