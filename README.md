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

# Desafios ao longo do desenvolvimento
Durante o desenvolvimento da API tive problemas ao consumir a API por um dispositvo Android, relacionado a CORS e Certificado SSL e com a URL, resolvi de maneira simples
autorizando o CleartextTraffic do dispositvo e verificando se ele é um emulador ou um dispositivo físico, durante o desenvolvimento do App

# API EndPoints importantes

- **GET /api/Attractions**
- **GET /api/Attractions/{CountryId}/GetAttractionByCountry**
- **GET /api/Attractions/{id}**
- **GET /api/Attractions/{rating}/GetAttractionsByRating**
- **GET /api/Attractions/GetRecomended**
