# API - Serviço de Coleta

## Descrição

Este serviço tem como objetivo coletar as respostas das pesquisas respondidas pelos usuários e enviá-las ao _Azure
Service Bus_

### Endpoints

![POST](https://img.shields.io/badge/POST-blue) `/pesquisas_publicas/enviar_respostas`

Content-Type: application/json

```json

{
    "pesquisaId": 123,
    "nomeRespondente": "João Silva",
    "emailRespondente": "joao.silva@example.com",
    "idadeRespondente": 30,
    "respostasIds": [1, 2, 3, 4, 5]
}
```

## Documentação da Arquitetura

- [x] [Documentação Completa](https://github.com/silviobassi/PesquisaPublica.Documents)

### Diagrama de Componentes do Projeto 👇🏻
  ![](http://www.plantuml.com/plantuml/png/dLN1RXit4BthArYr1mbmj4MGNWe4YAAeS0hBbhLASnH6oub4W4jkXgHRk-Z763tu7thLZtN8tLMbjIeOaG_cpdBU3DzxmttdF90FfUvzfqoXWqInzRvoFsSPmU-ZZVBRi0uEgR36e_6ZmfPPfS74d5VEIwtMsUJDgtaCVPfTPIKuZyIXrSIMbJKnfuhulR6K2zHBs0pwuEvDqRyGFsXbCFVt6iLRyG7S5kKLHmR3OQ-NNzvyNisdY_pcUdNpQNdryNewuF0SoLap87GCBb5QkX3znNzFVNwS4w8fjYZupzmf46cty-141GJ2Ygy1dLVMx1v9sVwmbzzpr-Lg-eSV5D8mn4JR8Bze88o07vJpfDP1YKJ3xXzf1GFi7hqgU2KsZCfn0Q92-cAf15EWaB7Uxd6Z33YkqPjmBYY3T1imO2ec7DATAf0fvZBZXq0eyZeatWSNQ_-YDDI7iWKw1mBSmNaaYbIF5muAoyf8E6n8Utwb8ZjghRII8F6ebTLx6um4kXzynlMughWGBmIlj2eWKYJoVD4VYZzxWdzxJPC0jmsBm2J63kkprXotaf2uFU8wgWKFKRNBvUpgGao-Zw6FnZDnK62TJ6roLwXE4o3Bqpr4NYQaOFUq-zlomxSqKN0-HIwHq1HnNQ7x6fIBQZvd8sZ__xqiqdkGrhsmjZKf8URIFbUuK3BsGrnp2t-Tr37QPs8rUc3OvANTKwAW3fwGCdgQabuk9KLGibeZnRHvM4Shx9biDwQJZFFvw7gw5CayIin-cyJer7aAFX28_UWrhk1_1t3FQ8pJqDGhm7RwFzj8Oh7jdEiqfptUrorNaPNJErxLuoM3j_MH6vrR4oi9_NOyHxCuXAphPjGCQZEdJNj7itbitqQp1UhZw-l4A8thKSToxxc6jmmrAcuJTFOJ_rx_-FgDI7w-N2xdURnIFMpSs-Q67JR5klZr7RT0xe3jb6GvcDtpSAk5scoRQ_Bu5fuo-RWvHAEsWdm9SjU8NJUqhDZJsTtjX-gUpppOUNGVDsZTxqLxR2KjAvISCRkTlvZxphHDpPqwvvf4NDS6wJFSnbo64ODMBKYouqs-p1BNsQ_y2NtUtJlM9dsN_mK0)

![GitHub](https://img.shields.io/badge/GitHub-Serviço%20de%20Coleta-blue?logo=github)
![Status](https://img.shields.io/badge/Status-Projeto%20em%20Desenvolvimento-yellow)