# ObserverChat
Link para Apresentacao: https://docs.google.com/presentation/d/1v3vXMO4ea1LiQiQ_n_46McogheZoCAWlhVe-Ww5jtVk/edit?usp=sharing

# Como executar

* Instale [.NET 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
* Execute o comando `donetn run` na pasta raiz deste repositório
* O servidor estará rodando no endereço `http://localhost:5130`

# Arquivos de interesse

* ChatHub.cs
  * Implementa o padrão de projeto observer, controla a lista de observadores e faz o "broadcast" das mensagens trocadas
* ChatRoom.razor
  * Aplicação cliente
