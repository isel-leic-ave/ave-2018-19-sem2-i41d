// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly 'App01-callvirt'
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module 'App01-callvirt.exe'
// MVID: {176826E3-7B96-4BDA-B097-122FD6C137A7}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x009A0000


// =============== CLASS MEMBERS DECLARATION ===================

.class public auto ansi beforefieldinit Person
       extends [mscorlib]System.Object
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Person::.ctor

} // end of class Person

.class public auto ansi beforefieldinit Student
       extends Person
{
  .field private int32 '<Nr>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .field private int32 '<Group>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .field private string '<Name>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .field private string '<GithubId>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .field private valuetype [mscorlib]System.DateTime '<BirthDate>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .method public hidebysig specialname instance int32 
          get_Nr() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 Student::'<Nr>k__BackingField'
    IL_0006:  ret
  } // end of method Student::get_Nr

  .method public hidebysig specialname instance void 
          set_Nr(int32 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      int32 Student::'<Nr>k__BackingField'
    IL_0007:  ret
  } // end of method Student::set_Nr

  .method public hidebysig specialname instance int32 
          get_Group() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 Student::'<Group>k__BackingField'
    IL_0006:  ret
  } // end of method Student::get_Group

  .method public hidebysig specialname instance void 
          set_Group(int32 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      int32 Student::'<Group>k__BackingField'
    IL_0007:  ret
  } // end of method Student::set_Group

  .method public hidebysig specialname instance string 
          get_Name() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      string Student::'<Name>k__BackingField'
    IL_0006:  ret
  } // end of method Student::get_Name

  .method public hidebysig specialname instance void 
          set_Name(string 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      string Student::'<Name>k__BackingField'
    IL_0007:  ret
  } // end of method Student::set_Name

  .method public hidebysig specialname instance string 
          get_GithubId() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      string Student::'<GithubId>k__BackingField'
    IL_0006:  ret
  } // end of method Student::get_GithubId

  .method public hidebysig specialname instance void 
          set_GithubId(string 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      string Student::'<GithubId>k__BackingField'
    IL_0007:  ret
  } // end of method Student::set_GithubId

  .method public hidebysig specialname instance valuetype [mscorlib]System.DateTime 
          get_BirthDate() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      valuetype [mscorlib]System.DateTime Student::'<BirthDate>k__BackingField'
    IL_0006:  ret
  } // end of method Student::get_BirthDate

  .method public hidebysig specialname instance void 
          set_BirthDate(valuetype [mscorlib]System.DateTime 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      valuetype [mscorlib]System.DateTime Student::'<BirthDate>k__BackingField'
    IL_0007:  ret
  } // end of method Student::set_BirthDate

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void Person::.ctor()
    IL_0006:  nop
    IL_0007:  nop
    IL_0008:  ret
  } // end of method Student::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 nr,
                               string name,
                               int32 group,
                               string githubId,
                               valuetype [mscorlib]System.DateTime b) cil managed
  {
    // Code size       51 (0x33)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void Person::.ctor()
    IL_0006:  nop
    IL_0007:  nop
    IL_0008:  ldarg.0
    IL_0009:  ldarg.1
    IL_000a:  call       instance void Student::set_Nr(int32)
    IL_000f:  nop
    IL_0010:  ldarg.0
    IL_0011:  ldarg.2
    IL_0012:  call       instance void Student::set_Name(string)
    IL_0017:  nop
    IL_0018:  ldarg.0
    IL_0019:  ldarg.3
    IL_001a:  call       instance void Student::set_Group(int32)
    IL_001f:  nop
    IL_0020:  ldarg.0
    IL_0021:  ldarg.s    githubId
    IL_0023:  call       instance void Student::set_GithubId(string)
    IL_0028:  nop
    IL_0029:  ldarg.0
    IL_002a:  ldarg.s    b
    IL_002c:  call       instance void Student::set_BirthDate(valuetype [mscorlib]System.DateTime)
    IL_0031:  nop
    IL_0032:  ret
  } // end of method Student::.ctor

  .method public hidebysig instance void 
          Print() cil managed
  {
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "I am a Student"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method Student::Print

  .property instance int32 Nr()
  {
    .get instance int32 Student::get_Nr()
    .set instance void Student::set_Nr(int32)
  } // end of property Student::Nr
  .property instance int32 Group()
  {
    .get instance int32 Student::get_Group()
    .set instance void Student::set_Group(int32)
  } // end of property Student::Group
  .property instance string Name()
  {
    .get instance string Student::get_Name()
    .set instance void Student::set_Name(string)
  } // end of property Student::Name
  .property instance string GithubId()
  {
    .get instance string Student::get_GithubId()
    .set instance void Student::set_GithubId(string)
  } // end of property Student::GithubId
  .property instance valuetype [mscorlib]System.DateTime
          BirthDate()
  {
    .get instance valuetype [mscorlib]System.DateTime Student::get_BirthDate()
    .set instance void Student::set_BirthDate(valuetype [mscorlib]System.DateTime)
  } // end of property Student::BirthDate
} // end of class Student

.class public auto ansi beforefieldinit App
       extends [mscorlib]System.Object
{
  .method public hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       24 (0x18)
    .maxstack  1
    .locals init (class Student V_0,
             class Student V_1)
    IL_0000:  nop
    IL_0001:  newobj     instance void Student::.ctor()
    IL_0006:  stloc.0
    IL_0007:  ldloc.0
    IL_0008:  callvirt   instance void Student::Print()
    IL_000d:  nop
    IL_000e:  ldnull
    IL_000f:  stloc.1
    IL_0010:  ldloc.1
    IL_0011:  call   instance void Student::Print()
    IL_0016:  nop
    IL_0017:  ret
  } // end of method App::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method App::.ctor

} // end of class App


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file C:\MyFolder\ISEL\pg5 ave - 2018-2019 - 2º sem\aulas\aula18-call-and-callvirt\App01.res
