# Makefile for .NET project

# Variables
PROJECT_NAME := CSharpSample

# Default target
all: build

# Build the project
build:
	dotnet build $(PROJECT_NAME).sln

# Run tests
test:
	dotnet test $(PROJECT_NAME).sln

# Clean the project
clean:
	dotnet clean $(PROJECT_NAME).sln

.PHONY: all build test clean