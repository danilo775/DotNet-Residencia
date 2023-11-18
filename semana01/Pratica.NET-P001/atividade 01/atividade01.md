Para verificar a versão do .NET SDK instalado no sistema, use o seguinte comando:

dotnet --info
Este comando exibirá informações sobre o .NET SDK, incluindo a versão instalada.

também pode usar o seguinte comando para verificar a versão do .NET SDK instalado:

dotnet --list-sdks
Este comando exibirá uma lista de todas as versões do .NET SDK instaladas em seu sistema.

Removendo o .NET SDK

Para remover o .NET SDK instalado no sistema, use o seguinte comando:

dotnet uninstall-sdk
Este comando removerá todas as versões do .NET SDK instaladas em seu sistema.

Você também pode usar o seguinte comando para remover uma versão específica do .NET SDK:

dotnet uninstall-sdk --version <versão>
Onde <versão> é a versão do .NET SDK que você deseja remover.

Atualizando o .NET SDK

Para atualizar o .NET SDK instalado no sistema, use o seguinte comando:

dotnet upgrade-sdk
Este comando atualizará todas as versões do .NET SDK instaladas no sistema para a versão mais recente.

Você também pode usar o seguinte comando para atualizar uma versão específica do .NET SDK:

dotnet upgrade-sdk --version <versão>
Onde <versão> é a versão do .NET SDK que você deseja atualizar.

Exemplo

Aqui está um exemplo de como usar esses comandos:

# Verifica a versão do .NET SDK instalado
dotnet --info

# Exibe uma lista de todas as versões do .NET SDK instaladas
dotnet --list-sdks

# Remove todas as versões do .NET SDK instaladas
dotnet uninstall-sdk

# Remove a versão 6.0.2 do .NET SDK
dotnet uninstall-sdk --version 6.0.2

# Atualiza todas as versões do .NET SDK instaladas para a versão mais recente
dotnet upgrade-sdk

# Atualiza a versão 6.0.2 do .NET SDK para a versão 6.0.3
dotnet upgrade-sdk --version 6.0.2
## Estes comandos também podem ser usados ​​em outras plataformas, como macOS e Linux.