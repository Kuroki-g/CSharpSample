# CSharpSample

This repository contains sample C# projects and code snippets to help you get started with C# programming.

## Getting Started

1. **Clone the repository:**

    ```sh
    git clone https://github.com/yourusername/CSharpSample.git
    ```

2. **Navigate to the project directory:**

    ```sh
    cd CSharpSample
    ```

## Prerequisites

- .NET SDK: [Download and install .NET SDK](https://dotnet.microsoft.com/download)

## Running the Samples

1. **Build the project:**

    ```sh
    dotnet build
    ```

2. **Run the project:**

    ```sh
    dotnet run
    ```

## Built With

For debugging the IL code, you can use the IL Disassembler (ILDAsm, GPLv3+) tool.
You can download the ILDAsm tool from the following link:
<https://www.nuget.org/packages/runtime.linux-x64.Microsoft.NETCore.ILDAsm>

Installation

```bash
wget https://www.nuget.org/api/v2/package/runtime.linux-x64.Microsoft.NETCore.ILDAsm/9.0.0
```

unzip it, you can get the binary file at "runtime.linux-x64.Microsoft.NETCore.ILDAsm/runtimes/linux-x64"

```bash
unzip -d runtime.linux-x64.Microsoft.NETCore.ILDAsm 9.0.0
```

Check the version.

```bash
$ ls ./runtime.linux-x64.Microsoft.NETCore.ILDAsm/runtimes/linux-x64/native/ildasm --version
ls (GNU coreutils) 8.32
Copyright (C) 2020 Free Software Foundation, Inc.
License GPLv3+: GNU GPL version 3 or later <https://gnu.org/licenses/gpl.html>.
This is free software: you are free to change and redistribute it.
There is NO WARRANTY, to the extent permitted by law.

Written by Richard M. Stallman and David MacKenzie.
```

Move this and you can call directly.

```bash
mv ./runtime.linux-x64.Microsoft.NETCore.ILDAsm/runtimes/linux-x64/native/ildasm /usr/local/bin/
```

```bash
chmod u+x /usr/local/bin/ildasm 
```

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For any questions or suggestions, please open an issue or contact the repository owner.
