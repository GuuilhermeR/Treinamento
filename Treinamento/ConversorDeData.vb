'Module ConversorDeData

'    Public TeclaPressionada As String

'    Public UltimoChar As String



'    Public Sub ApenasNumeros(Tecla As KeyPressEventArgs, Caixa As Object)
'        TeclaPressionada = Tecla.KeyChar
'        If Caixa.SelectionStart - 1 <> -1 Then
'            UltimoChar = Caixa.text.chars(Caixa.SelectionStart - 1)
'        Else
'            UltimoChar = ""
'        End If

'        If (AscW(Tecla.KeyChar) < 48 Or AscW(Tecla.KeyChar) > 57) And (AscW(Tecla.KeyChar) <> 8) Then

'            Tecla.KeyChar = ""

'        End If

'    End Sub



'    Public Sub MaskData(Caixa As Object)

'        Dim Cursor As Integer

'        Dim Mask As String

'        Caixa.MaxLength = 10

'        If AscW(TeclaPressionada) <> 8 Then

'            Cursor = Caixa.SelectionStart

'            If Len(Caixa.text) = 2 Or Len(Caixa.text) = 5 Then

'                Cursor = Cursor + 1

'            End If

'            Mask = Replace(Caixa.text, "/", "")


'            If Len(Mask) < 5 And Len(Mask) >= 2 Then

'                Mask = Mask.Insert(2, "/")

'            End If

'            If Len(Mask) >= 5 Then

'                Mask = Replace(Caixa.text, "/", "")

'                Mask = Mask.Insert(2, "/")

'                Mask = Mask.Insert(5, "/")

'            End If

'            Caixa.text = Mask

'            Caixa.SelectionStart = Cursor
'        Else
'            If UltimoChar = "/" Then
'                SendKeys.Send("{BACKSPACE}")
'            End If
'        End If

'    End Sub
'End Module
