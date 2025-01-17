using SharpLab.Runtime;

static class C<T> {
    static void M() {}

    static class N {
        static void M() {}
    }
}

static class C {
    static void M<T>() {}

    static class N<T> {
        static void M() {}
    }
}

/* asm

; Desktop CLR <IGNORE> on amd64

Microsoft.CodeAnalysis.EmbeddedAttribute..ctor()
    L0000: ret

System.Runtime.CompilerServices.RefSafetyRulesAttribute..ctor(Int32)
    L0000: mov [rcx+0x8], edx
    L0003: ret

C`1.M()
    ; Open generics cannot be JIT-compiled.
    ; However you can use attribute SharpLab.Runtime.JitGeneric to specify argument types.
    ; Example: [JitGeneric(typeof(int)), JitGeneric(typeof(string))] void M<T>() { ... }.

C`1+N.M()
    ; Open generics cannot be JIT-compiled.
    ; However you can use attribute SharpLab.Runtime.JitGeneric to specify argument types.
    ; Example: [JitGeneric(typeof(int)), JitGeneric(typeof(string))] void M<T>() { ... }.

C.M()
    ; Open generics cannot be JIT-compiled.
    ; However you can use attribute SharpLab.Runtime.JitGeneric to specify argument types.
    ; Example: [JitGeneric(typeof(int)), JitGeneric(typeof(string))] void M<T>() { ... }.

C+N`1.M()
    ; Open generics cannot be JIT-compiled.
    ; However you can use attribute SharpLab.Runtime.JitGeneric to specify argument types.
    ; Example: [JitGeneric(typeof(int)), JitGeneric(typeof(string))] void M<T>() { ... }.

*/