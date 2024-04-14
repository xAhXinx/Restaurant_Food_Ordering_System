Imports System.Data.SqlClient
Public Class FrmShowMenuTap

    Dim intTableNum As Integer
    Const INT_MENU_HEIGHT As Integer = 4
    Const INT_MENU_WIDTH As Integer = 4
    Dim btnArr As Button() = {}
    Dim intPageNUM As Integer = 1


    Private Sub FrmShowMenuTap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim menuItemsResult As MenuItem() = ReturnMenuItems("BEV")

        ''Init buttons if not exist
        'If btnArr.Length = 0 Then
        '    For i = 1 To INT_MENU_HEIGHT
        '        For j = 1 To INT_MENU_WIDTH
        '            Dim btnNew As New System.Windows.Forms.Button()
        '            Dim menuSize As Size = pnlOutput.Size

        '            btnArr.Append(btnNew)
        '            pnlOutput.Controls.Add(btnNew)
        '            btnNew.Height = (menuSize.Height - 10D) / (INT_MENU_HEIGHT)
        '            btnNew.Width = (menuSize.Width - 10D) / (INT_MENU_WIDTH)
        '            btnNew.Top = menuSize.Height * ((i - 1) / INT_MENU_HEIGHT)
        '            btnNew.Left = menuSize.Width * ((j - 1) / INT_MENU_WIDTH)
        '            btnNew.Text = "Press me"


        '        Next
        '    Next
        'End If

    End Sub

    Private Function ReturnMenuItems(menuType As String) As MenuItem()
        Dim db As New OrderDataContext()

        Dim menuItemsOutput As MenuItem() = {}

        For Each row In db.MenuItems
            If Not row.MenuItemID.IndexOf(menuType) = -1 Then
                menuItemsOutput.Append(row)
            End If
        Next
        Return menuItemsOutput
    End Function

End Class


