# Build shared lib

```
mkdir build && cd build && cmake .. && make
```

# Build console

```
dotnet build && otnet publish -c Release -o ./build/lib
```

# Run console

```
cd lib
./pinvoke
```