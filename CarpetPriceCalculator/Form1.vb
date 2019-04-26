Public Class Form1

    Dim MyCarpet As Carpet
    Dim Room As Rectangle

    Dim ErrorCodes(4) As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set Error Codes
        Dim x As Integer
        For x = 0 To 4
            ErrorCodes(x) = False
        Next

    End Sub

    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click

        If (ValidateEntries()) Then

            'Calculate the Area and price
            MyCarpet = New Carpet(txt_Color.Text, txt_Style.Text, CDec(txt_Price.Text))
            Room = New Rectangle(CSng(txt_Width.Text), CSng(txt_Length.Text))

            Room.CalcArea()
            lbl_Area.Text = Room.Area.ToString("N2") + " square feet"

            lbl_Cost.Text = (MyCarpet.Price * Room.Area).ToString("c2")
        Else

            'Display Error Message(s)
            DisplayErrMessages()
        End If
    End Sub

    Private Function ValidateEntries() As Boolean
        Dim output As Boolean = True
        Dim temp1 As Decimal
        Dim temp2 As Single

        'Check for null, Empty, or whitespace in Entry areas
        'If any of these are true then set output to False, else set output to itself
        output = If(String.IsNullOrEmpty(txt_Color.Text) Or String.IsNullOrWhiteSpace(txt_Color.Text), SetErrorCode(0), output)

        output = If(String.IsNullOrEmpty(txt_Style.Text) Or String.IsNullOrWhiteSpace(txt_Style.Text), SetErrorCode(1), output)

        output = If(String.IsNullOrEmpty(txt_Price.Text) Or String.IsNullOrWhiteSpace(txt_Price.Text), SetErrorCode(2), output)

        output = If(String.IsNullOrEmpty(txt_Width.Text) Or String.IsNullOrWhiteSpace(txt_Width.Text), SetErrorCode(3), output)

        output = If(String.IsNullOrEmpty(txt_Length.Text) Or String.IsNullOrWhiteSpace(txt_Length.Text), SetErrorCode(4), output)

        'Check for a Decimal in the Price Textbox
        output = If(Decimal.TryParse(txt_Price.Text, temp1) And temp1 >= 0, output, SetErrorCode(2))

        ' Check for Singles in Length and Width TextBoxes
        ' If numbers are Singles then return existing output value, otherwise return false
        output = If(Single.TryParse(txt_Width.Text, temp2) And temp2 >= 0, output, SetErrorCode(3))

        output = If(Single.TryParse(txt_Length.Text, temp2) And temp2 >= 0, output, SetErrorCode(4))

        Return output
    End Function

    Private Function SetErrorCode(ByRef index As Integer) As Boolean
        ErrorCodes(index) = True
        Return False
    End Function

    Private Sub DisplayErrMessages()

        'Declare message Variable for displaying
        Dim msg As String = String.Empty
        Dim x As Integer

        'Declare Error Message for each Code
        Dim errorMsg(4) As String

        errorMsg(0) = "Color must not be Blank or Spaces."
        errorMsg(1) = "Style must not be Blank or Spaces."
        errorMsg(2) = "Price must be a positive number."
        errorMsg(3) = "Width must be a positive number."
        errorMsg(4) = "Length must be a positive number."

        For x = 0 To 4
            If (ErrorCodes(x)) Then
                MessageBox.Show(errorMsg(x), "Entry Error")
            End If
        Next


    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click

        'Clear all text boxes and output labels
        txt_Color.Text = String.Empty
        txt_Length.Text = String.Empty
        txt_Price.Text = String.Empty
        txt_Style.Text = String.Empty
        txt_Width.Text = String.Empty

        lbl_Area.Text = String.Empty
        lbl_Cost.Text = String.Empty
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub
End Class
