## Sumário
1. [Descrição](#tourtrack---app-de-pontos-turísticos)
2. [Tecnologias utilizadas](#tecnologias-utilizadas)
3. [Desafios ao longo do desenvolvimento](#desafios-ao-longo-do-desenvolvimento)
4. [API EndPoints importantes](#api-endpoints-importantes)

## TourTrack - App de pontos turísticos  
Este é um aplicativo que oferece a possibilidade de explorar vários pontos turísticos ao redor do mundo. O app fornece informações detalhadas sobre cada atração, como:

- Localização: Coordenadas e endereço.
- Horário de abertura: Dias e horários em que a atração está disponível para visitação.
- Valor de entrada: Preço dos ingressos.
- Imagens: Fotos das atrações para visualização.
- Descrição: Uma breve descrição para contextualizar a história ou importância da atração.

Ao todo demorei cerca de 20 a 30 dias pra criação do projeto + Api, gostei muito de fazer, pois é um projeto pessoal meu, e sou apaixonado por viagens e tudo que seja relacionado,
com esse aplicativo usuarios como eu, podem ver detalhes do seu destino turistico e também descobrir novos lugares que eles queiram conhecer

# Tecnologias utilizadas
- **.NET MAUI** - Framewkork
- **C#** - Linguagem de programção
- **XAML** - Linguagem de marcação
- **SQLite** - Banco de dados
- **SQLserver** - Banco de dados
- **ASP.NET Core**
- **CommunityToolkit**
- **EntityFrameworkCore**
- **MVVM** - Padrão de projeto utilizado
- 
## Futuras Melhorias
- Integração com mapas para navegação até as atrações.
- Suporte a múltiplos idiomas.
- Notificações sobre eventos em atrações favoritas.

# Desafios ao longo do desenvolvimento
Durante o desenvolvimento da API tive problemas ao consumir a API por um dispositvo Android, relacionado a CORS e Certificado SSL e com a URL, resolvi de maneira simples
autorizando o CleartextTraffic do dispositvo e verificando se ele é um emulador ou um dispositivo físico, durante o desenvolvimento do App

# API EndPoints importantes

- **GET /api/Attractions** - Retorna uma lista completa de atrações
- **GET /api/Attractions/{CountryId}/GetAttractionByCountry** - Retorna uma lista de atrações por país, cada atração está ligada a um pais pelo id do País
- **GET /api/Attractions/{id}** - Retorna uma atração pelo id especificado
- **GET /api/Attractions/{rating}/GetAttractionsByRating** - Retorna uma lista de atrações que possuem um rating igual ou superior do especificado
- **GET /api/Attractions/GetRecomended** - Retorna uma lista de atrações recomendadas
  
## Feedback e Suporte
Se você encontrar algum problema ou tiver sugestões, por favor, abra uma issue no GitHub ou entre em contato via email: [seuemail@exemplo.com](mailto:seuemail@exemplo.com).

## Licença
Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
