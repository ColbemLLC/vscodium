default:
    just --list

setup:
    git submodule update --init --recursive
    dotnet restore

build:
    dotnet build

run:
    dotnet run --project Codium/Codium.csproj

clean:
    dotnet clean