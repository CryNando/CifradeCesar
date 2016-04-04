Public Class CifraCesar

    'DANGER GLOBAL VARIABLES!!!
    Dim texto As String = "" 'Váriavel que pega o que está escrito no tbTexto
    Dim resultado As String = "" 'Variavel que guardará o texto gerado
    Dim auxiliar As Integer = 0 'Váriavel que guardará o Asci do Caracter 


    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click

        texto = tbTexto.Text 'Passa oque está no textbox para variavel texto

        Try 'Tratamento de erro
            For i As Integer = 0 To texto.Length - 1 'Loop que percorrará a string inteira do texto
                auxiliar = Asc(texto(i)) 'Pega o número Asc do Caracter

                If (auxiliar >= 65 And auxiliar <= 90) Then 'Se o caracter for MAISCULO
                    auxiliar = auxiliar + tbKey.Text ' Soma o Asc com a Chave digitada

                    If (auxiliar > 90) Then ' Se a conversão passar do Z
                        auxiliar = auxiliar - 26 'Volta para o Inicio do alfabeto
                    End If

                    resultado = resultado + Chr(auxiliar) 'Salva o caracter convertido na nova string

                ElseIf (auxiliar >= 97 And auxiliar <= 122) Then ' Se o caracter for MINUSCULO
                    auxiliar = auxiliar + tbKey.Text ' Soma o Asc com a chave digitada

                    If (auxiliar > 122) Then ' Se a conversão passar de z
                        auxiliar = auxiliar - 26 'Volta ao ínicio do alfabeto
                    End If

                    resultado = resultado + Chr(auxiliar) 'Salva o caracter convertido na nova string

                Else 'Caso o caracter não foi uma letra 
                    resultado = resultado + Chr(auxiliar) 'Salva o caracter na nova string
                End If

            Next 'Fim do Loop

            tbResultado.Text = resultado 'O tbResultado mostra a string resultado.
            resultado = "" ' reseta a string caso venha ser usada novamente
        Catch
            MsgBox("Preencha os campos necessários", , "Cifra de César") 'Campo da chave não pode estar vazio
        End Try
    End Sub

    Private Sub btn_Decrypt_Click(sender As Object, e As EventArgs) Handles btn_Decrypt.Click

        texto = tbTexto.Text 'Passa oque está no textbox para variavel texto
        If (tbKey.Text <> "" Or tbTexto.Text <> "") Then 'Verifica se os dois texto não estão vazios
            For i As Integer = 0 To texto.Length - 1 'Loop que percorrará a string inteira do texto
                auxiliar = Asc(texto(i)) 'Pega o número Asc do Caracter

                If (auxiliar >= 65 And auxiliar <= 90) Then 'Se o caracter for MAISCULO
                    auxiliar = auxiliar - tbKey.Text ' Soma o Asc com a Chave digitada

                    If (auxiliar < 65) Then ' Se a conversão passar do Z
                        auxiliar = auxiliar + 26 'Vai para o fim do alfabeto
                    End If

                    resultado = resultado + Chr(auxiliar) 'Salva o caracter convertido na nova string

                ElseIf (auxiliar >= 97 And auxiliar <= 122) Then ' Se o caracter for MINUSCULO
                    auxiliar = auxiliar - tbKey.Text ' Soma o Asc com a chave digitada

                    If (auxiliar < 97) Then ' Se a conversão passar de z
                        auxiliar = auxiliar + 26 'Vai para o fim do alfabeto
                    End If

                    resultado = resultado + Chr(auxiliar) 'Salva o caracter convertido na nova string

                Else 'Caso o caracter não foi uma letra 
                    resultado = resultado + Chr(auxiliar) 'Salva o caracter na nova string
                End If

            Next 'Fim do Loop

            tbResultado.Text = resultado 'O tbResultado mostra a string resultado.
            resultado = "" 'Reseta a string caso venha ser usada novamente
        Else
            MsgBox("Preencha o Campo KEY", , "Cifra de César")
        End If
    End Sub

    Private Sub btn_Encrypt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbResultado.Enabled = False 'O campo do resultado não pode ser modificado manualmente
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        tbTexto.Clear()
        tbResultado.Clear()
        tbKey.Clear()
        tbTexto.Focus()
    End Sub
End Class
