# Consultar-CEP-Correios-WebService
Aplicação em Visual Basic .net para consultar CEP nos correios utilizando o WebService


## Manual de integração

https://github.com/diogoschimm/Consultar-CEP-Correios-WebService/blob/master/docs/Manual_de_Implementacao_do_Web_Service_SIGEPWEB_Logistica_Reversa1.pdf

![image](https://user-images.githubusercontent.com/30643035/70532790-1a2fb080-1b2e-11ea-8953-162e95031260.png)

## Link do WebService

https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl

## Código de Integração em Visual Basic .Net

```vb
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
```

