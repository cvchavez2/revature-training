# audit

## command line [Linux]
- create a file -> touch
- create a directory -> mkdir
- display the content of a directory -> ls, flags = -a (list everything), -l (with description)
change the directory -> cd
remove file or directory -> rm, flags = -r (recursive), -f (force)
running priviliged commands or as administrator -> sudo
install new packages -> apt install
read file content -> cat
edit file content -> nano
print current path -> pwd

## version control system [VCS with Git]
git add -> copy resources into virtual directory or local server
git commit -> save resources to virtual directory or local server
git status -> display changed resources in history
git init -> initialize virtual directory or local server
git config -> configure name, email or git options
git remote -> edit or remove connection to remote server
git clone -> copy resources from remote server to local server
git push -> copy resources from local server to remote server
git log -> print history of virtual directory or local server

## secure shell [SSH]
ssh-keygen -> generate a private/public keypair, similar to username and password, flags = -t (algorithm type), -b (binary length), -C (comment)
ssh-agent -> run current directory in privileged state with ssh
ssh-add -> add private key to priviliged state with ssh

## dotnet [.NET]
.NET Standard = supports both the .NET Framework (Windows only) and .NET Core (multi platform), a set of APIs to interface with your OS
.NET Core = supports Languages, Desktop Apps, Mobile Apps, Web Apps
Languages = support for C#, F#, Visual Basic, VB.NET, C, C++, Python, JavaScript
Desktop = support for UWP/UAP (Win10), XAML (Win10), WPF (Win7,8)
Mobile = support for Xamarin (Windows, Android, iOS/ipadOS)
Web = support for MVC, Web API (REST), gRPC (RPC)

## csharp [C#]
- CIL, MSIL, IL = compile to intermediate language (assembly), support CLI (Common Language Infrastructure/Interface)
- Assembly = compliled codebase into DLL, EXE or SVC (Web, Host)
- Language = object-based, strongly-typed, compiled, managed, general programming
- Datatypes = primitives, reference, value
- Primitive = int, float, double, decimal, string, char, bool (including unsigned)
- Reference = string, class, interface
- Value = all primitives except string, struct, enum
- CLR = .NET Runtime from assembly to bytecode/machine code, support BCL (base class lib), CTS (common type sys), VES (virtual execution sys), JIT (just in time compiler)
- Runtime = portability, interoperability, memory management, performance
Scopes = support for 4 level of scoping, namely namespace, data structure (class, interface, struct, enum), method, block(control flow, exception handling)
- Collections = support for array (1-d, multi-dimensional), for list
- Exception Handling = handle with try/catch/throw/finally, possible try with no catch (not recommended), catch (handle at error or throw to invocation caller), finally (handle resources cleanup)
- unit testing = support for runnung codebase logic without application start, structurally steup with arrange/act/assert block, 
- Serialization = convert data from one system to another
- debugging = support for running codebase in steeps including breakpoints, conditions, handle logic errors
- Modifiers = support 2 types, access (public > protected > internal > private) and regular/extended (const, readonly(instantiated only in constructor or compile time), static, override(changing initial implementation))
- Method Overloading
- Method Overriding 
- OOP = support for Abstraction(it has a template for implementation, no concrete implementation), Encapsulation, Inheritance (we want to modify an existing implementation, we therefor extend it and modify for our specs), Polymorphism (static - overloading, dynamic - overriding)(a structure can change to different forms) (satisfy IS-A relation)
- Casting = support for implicit (smaller to larger, usually done with primitives) and explicit (exception casting `(datatype) object` or null casting with `object as datatype`)
- Reference = support for `ref` (pass by value with value being the reference/pointer to memory address) and `out` (pass by value with value being the copy of the variable content)
- Parsing = support for converting between primitivee datatypes
