PROJECT_NAME = Record.Sample
CONFIGURATION = Release

all: build

build:
	dotnet build $(PROJECT_NAME).csproj -c $(CONFIGURATION)

clean:
	dotnet clean $(PROJECT_NAME).csproj -c $(CONFIGURATION)

dump:
	make build
	ildasm ./bin/Release/net8.0/Record.Sample.dll -out=Record.Sample.il -utf8
dump-html:
	make build
	ildasm ./bin/Release/net8.0/Record.Sample.dll -out=Record.Sample.il.html -html -utf8
