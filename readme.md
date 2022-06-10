# Prerequisite

1. Linux
2. CMake
3. Net 6 SDK

# Build shared lib

```
mkdir build && cd build && cmake .. && make
```

# Build console

```
cd ..
dotnet build && dotnet publish -c Release -o ./build/lib
```

# Run console

```
cd build/lib
./pinvoke
```
