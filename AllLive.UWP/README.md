# AllLive.UWP


UWP��֧��QuickJS,����Releaseʱ��Ҫ�޸�AllLive.Core��Ŀ��csproj�ļ�:

1�������޸�

```
<PackageReference Include="QuickJS.NET" Version="0.0.3" />
<!-- �޸�Ϊ�������ݣ���ȥ��QuickJS.NET���� -->
<PackageReference Include="QuickJS.NET" Version="0.0.3" PrivateAssets="all" />
```

2���������������ţ�WINDOWS_UWP

```
<PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Release|AnyCPU'">
   <DefineConstants>TRACE;WINDOWS_UWP</DefineConstants>
</PropertyGroup>
```
