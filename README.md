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

        MsgBox(str.ToString)

    End Sub
```


## Código para Insominia (REST)

POST: https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl

```xml
<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" 
                  xmlns:cli="http://cliente.bean.master.sigep.bsb.correios.com.br/">
    <soapenv:Header />
    <soapenv:Body>
        <cli:consultaCEP>
            <cep>78005100</cep>
        </cli:consultaCEP>
    </soapenv:Body>
</soapenv:Envelope>
```

Retorno

```xml
<soap:Envelope
  xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
    <ns2:consultaCEPResponse
      xmlns:ns2="http://cliente.bean.master.sigep.bsb.correios.com.br/">
      <return>
        <bairro>Centro-Norte</bairro>
        <cep>78005100</cep>
        <cidade>Cuiabá</cidade>
        <complemento2>- de 949/950 a 1898/1899</complemento2>
        <end>Avenida Marechal Deodoro</end>
        <uf>MT</uf>
      </return>
    </ns2:consultaCEPResponse>
  </soap:Body>
</soap:Envelope>
```
