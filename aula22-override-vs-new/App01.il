
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.6.1055.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly App
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module App.exe
// MVID: {6D9EA720-D512-4E3D-9217-6320D27B29F0}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x005F0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private sequential ansi sealed beforefieldinit Point
       extends [mscorlib]System.ValueType
{
  .field private int32 x
  .field private int32 y
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 x,
                               int32 y) cil managed
  {
    // Code size       16 (0x10)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldarg.1
    IL_0003:  stfld      int32 Point::x
    IL_0008:  ldarg.0
    IL_0009:  ldarg.2
    IL_000a:  stfld      int32 Point::y
    IL_000f:  ret
  } // end of method Point::.ctor

  .method public hidebysig specialname instance int32 
          get_X() cil managed
  {
    // Code size       12 (0xc)
    .maxstack  1
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      int32 Point::x
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a

    IL_000a:  ldloc.0
    IL_000b:  ret
  } // end of method Point::get_X

  .method public hidebysig specialname instance void 
          set_X(int32 'value') cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldarg.1
    IL_0003:  stfld      int32 Point::x
    IL_0008:  ret
  } // end of method Point::set_X

  .method public hidebysig specialname instance int32 
          get_Y() cil managed
  {
    // Code size       12 (0xc)
    .maxstack  1
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      int32 Point::y
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a

    IL_000a:  ldloc.0
    IL_000b:  ret
  } // end of method Point::get_Y

  .method public hidebysig specialname instance void 
          set_Y(int32 'value') cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldarg.1
    IL_0003:  stfld      int32 Point::y
    IL_0008:  ret
  } // end of method Point::set_Y

  .method public hidebysig instance float64 
          Module() cil managed
  {
    // Code size       39 (0x27)
    .maxstack  3
    .locals init (float64 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      int32 Point::x
    IL_0007:  ldarg.0
    IL_0008:  ldfld      int32 Point::x
    IL_000d:  mul
    IL_000e:  ldarg.0
    IL_000f:  ldfld      int32 Point::y
    IL_0014:  ldarg.0
    IL_0015:  ldfld      int32 Point::y
    IL_001a:  mul
    IL_001b:  add
    IL_001c:  conv.r8
    IL_001d:  call       float64 [mscorlib]System.Math::Sqrt(float64)
    IL_0022:  stloc.0
    IL_0023:  br.s       IL_0025

    IL_0025:  ldloc.0
    IL_0026:  ret
  } // end of method Point::Module

  .property instance int32 X()
  {
    .get instance int32 Point::get_X()
    .set instance void Point::set_X(int32)
  } // end of property Point::X
  .property instance int32 Y()
  {
    .get instance int32 Point::get_Y()
    .set instance void Point::set_Y(int32)
  } // end of property Point::Y
} // end of class Point

.class public auto ansi beforefieldinit Person
       extends [mscorlib]System.Object
{
  .field private string '<Name>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .method public hidebysig specialname instance string 
          get_Name() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      string Person::'<Name>k__BackingField'
    IL_0006:  ret
  } // end of method Person::get_Name

  .method public hidebysig specialname instance void 
          set_Name(string 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      string Person::'<Name>k__BackingField'
    IL_0007:  ret
  } // end of method Person::set_Name

  .method public hidebysig instance void 
          Print() cil managed
  {
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "I am a Person"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method Person::Print

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

  .property instance string Name()
  {
    .get instance string Person::get_Name()
    .set instance void Person::set_Name(string)
  } // end of property Person::Name
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

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 nr,
                               string name,
                               int32 group) cil managed
  {
    // Code size       40 (0x28)
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
    IL_0012:  call       instance void Person::set_Name(string)
    IL_0017:  nop
    IL_0018:  ldarg.0
    IL_0019:  ldarg.3
    IL_001a:  call       instance void Student::set_Group(int32)
    IL_001f:  nop
    IL_0020:  ldarg.0
    IL_0021:  call       instance void Student::Print()
    IL_0026:  nop
    IL_0027:  ret
  } // end of method Student::.ctor

  .method public hidebysig virtual instance string 
          ToString() cil managed
  {
    // Code size       35 (0x23)
    .maxstack  2
    .locals init (string V_0,
             string V_1)
    IL_0000:  nop
    IL_0001:  ldstr      "calling base..."
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ldarg.0
    IL_000d:  callvirt       instance string [mscorlib]System.Object::ToString()
    IL_0012:  stloc.0
    IL_0013:  ldloc.0
    IL_0014:  ldstr      " I am Student"
    IL_0019:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_001e:  stloc.1
    IL_001f:  br.s       IL_0021

    IL_0021:  ldloc.1
    IL_0022:  ret
  } // end of method Student::ToString

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
} // end of class Student

.class public auto ansi beforefieldinit WorkerStudent
       extends Person
{
  .method public hidebysig instance void 
          Print() cil managed
  {
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "I am a WorkerStudent"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method WorkerStudent::Print

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void Person::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method WorkerStudent::.ctor

} // end of class WorkerStudent

.class public auto ansi beforefieldinit App
       extends [mscorlib]System.Object
{
  .method public hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       63 (0x3f)
    .maxstack  3
    .locals init (class Student V_0,
             string V_1,
             valuetype Point V_2)
    IL_0000:  nop
    IL_0001:  ldc.i4     0xfe76
    IL_0006:  ldstr      "Ze Manel"
    IL_000b:  ldc.i4.s   11
    IL_000d:  newobj     instance void Student::.ctor(int32,
                                                      string,
                                                      int32)
    IL_0012:  stloc.0
    IL_0013:  ldloc.0
    IL_0014:  callvirt   instance string [mscorlib]System.Object::ToString()
    IL_0019:  stloc.1
    IL_001a:  ldloc.1
    IL_001b:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0020:  nop
    IL_0021:  ldloca.s   V_2
    IL_0023:  ldc.i4.5
    IL_0024:  ldc.i4.7
    IL_0025:  call       instance void Point::.ctor(int32,
                                                    int32)
    IL_002a:  ldloca.s   V_2
    IL_002c:  call       instance float64 Point::Module()
    IL_0031:  pop
    IL_0032:  ldloc.2
    IL_0033:  box        Point
    IL_0038:  call       instance class [mscorlib]System.Type [mscorlib]System.Object::GetType()
    IL_003d:  pop
    IL_003e:  ret
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
// WARNING: Created Win32 resource file C:\MyFolder\ISEL\pg5 ave - 2018-2019 - 2º sem\aulas\aula22-override-vs-new\App01.res
