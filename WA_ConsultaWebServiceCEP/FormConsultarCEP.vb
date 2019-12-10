Public Class FormConsultarCEP

    Private Sub btn_CEP_Click(sender As Object, e As EventArgs) Handles btn_CEP.Click

        '   URL do Web Service dos Correios
        '   https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente

        Dim wsCorreio As New CORREIOS.AtendeClienteClient()
        Dim retorno As CORREIOS.enderecoERP = wsCorreio.consultaCEP(txt_CEP.Text)

        Dim str As New Text.StringBuilder

        str.AppendLine($"CEP: {retorno.cep}")
        str.AppendLine($"ENDEREÇO: {retorno.end}")
        str.AppendLine($"Bairro: {retorno.bairro}")
        str.AppendLine($"Cidade: {retorno.cidade}")
        str.AppendLine($"UF: {retorno.uf}")
        str.AppendLine($"Complemento: {retorno.complemento}")
        str.AppendLine($"Complemento 2: {retorno.complemento2}")

        If retorno.unidadesPostagem IsNot Nothing Then
            For Each unidade As CORREIOS.unidadePostagemERP In retorno.unidadesPostagem

                str.AppendLine("*** Diretório Regional ***")
                str.AppendLine($" {unidade.diretoriaRegional}")
                str.AppendLine($" {unidade.endereco}")
                str.AppendLine($" {unidade.nome}")
                str.AppendLine($" {unidade.status}")
                str.AppendLine($" {unidade.tipo}")
                str.AppendLine("")

            Next
        End If

        MsgBox(str.ToString)

    End Sub

End Class
