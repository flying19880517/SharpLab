static class C {
    static int M(int[] x) {
        return x[0];
    }
}

/* asm

; Core CLR <IGNORE> on x64

C.M(Int32[])
    L0000: sub rsp, 0x28
    L0004: cmp dword ptr [rcx+8], 0
    L0008: jbe short L0012
    L000a: mov eax, [rcx+0x10]
    L000d: add rsp, 0x28
    L0011: ret
    L0012: call 0x<IGNORE>
    L0017: int3

Microsoft.CodeAnalysis.EmbeddedAttribute..ctor()
    L0000: ret

System.Runtime.CompilerServices.NullableAttribute..ctor(Byte)
    L0000: push rdi
    L0001: push rsi
    L0002: sub rsp, 0x28
    L0006: mov rsi, rcx
    L0009: mov edi, edx
    L000b: mov rcx, 0x<IGNORE>
    L0015: mov edx, 1
    L001a: call 0x<IGNORE>
    L001f: mov [rax+0x10], dil
    L0023: lea rcx, [rsi+8]
    L0027: mov rdx, rax
    L002a: call 0x<IGNORE>
    L002f: nop
    L0030: add rsp, 0x28
    L0034: pop rsi
    L0035: pop rdi
    L0036: ret

System.Runtime.CompilerServices.NullableAttribute..ctor(Byte[])
    L0000: lea rcx, [rcx+8]
    L0004: call 0x<IGNORE>
    L0009: nop
    L000a: ret

System.Runtime.CompilerServices.NullableContextAttribute..ctor(Byte)
    L0000: mov [rcx+8], dl
    L0003: ret

System.Runtime.CompilerServices.RefSafetyRulesAttribute..ctor(Int32)
    L0000: mov [rcx+8], edx
    L0003: ret

*/