# CS_ARCH_ARM, CS_MODE_THUMB+CS_MODE_V8+CS_MODE_MCLASS, None
0x31,0xfe,0x08,0x0f = vcmp.f16 eq, q0, q4
0x35,0xfe,0x8e,0x0f = vcmp.f16 ne, q2, q7
0x31,0xfe,0x00,0x1f = vcmp.f16 ge, q0, q0
0x31,0xfe,0x82,0x1f = vcmp.f16 lt, q0, q1
0x33,0xfe,0x09,0x1f = vcmp.f16 gt, q1, q4
0x35,0xfe,0x8d,0x1f = vcmp.f16 le, q2, q6
0x35,0xee,0x0a,0x0f = vcmp.f32 eq, q2, q5
0x37,0xee,0x88,0x0f = vcmp.f32 ne, q3, q4
0x31,0xee,0x0e,0x1f = vcmp.f32 ge, q0, q7
0x3b,0xee,0x84,0x1f = vcmp.f32 lt, q5, q2
0x35,0xee,0x0f,0x1f = vcmp.f32 gt, q2, q7
0x35,0xee,0x89,0x1f = vcmp.f32 le, q2, q4
0x09,0xfe,0x0c,0x0f = vcmp.i8 eq, q4, q6
0x05,0xfe,0x84,0x0f = vcmp.i8 ne, q2, q2
0x09,0xfe,0x0c,0x0f = vcmp.i8 eq, q4, q6
0x05,0xfe,0x84,0x0f = vcmp.i8 ne, q2, q2
0x09,0xfe,0x0c,0x0f = vcmp.i8 eq, q4, q6
0x05,0xfe,0x84,0x0f = vcmp.i8 ne, q2, q2
0x01,0xfe,0x00,0x1f = vcmp.s8 ge, q0, q0
0x05,0xfe,0x8e,0x1f = vcmp.s8 lt, q2, q7
0x09,0xfe,0x07,0x1f = vcmp.s8 gt, q4, q3
0x0f,0xfe,0x87,0x1f = vcmp.s8 le, q7, q3
0x03,0xfe,0x89,0x0f = vcmp.u8 hi, q1, q4
0x03,0xfe,0x09,0x0f = vcmp.u8 cs, q1, q4
0x19,0xfe,0x0e,0x0f = vcmp.i16 eq, q4, q7
0x15,0xfe,0x82,0x0f = vcmp.i16 ne, q2, q1
0x13,0xfe,0x0e,0x1f = vcmp.s16 ge, q1, q7
0x11,0xfe,0x82,0x1f = vcmp.s16 lt, q0, q1
0x13,0xfe,0x0f,0x1f = vcmp.s16 gt, q1, q7
0x15,0xfe,0x83,0x1f = vcmp.s16 le, q2, q1
0x13,0xfe,0x89,0x0f = vcmp.u16 hi, q1, q4
0x13,0xfe,0x09,0x0f = vcmp.u16 cs, q1, q4
0x25,0xfe,0x0e,0x0f = vcmp.i32 eq, q2, q7
0x25,0xfe,0x88,0x0f = vcmp.i32 ne, q2, q4
0x2b,0xfe,0x0a,0x1f = vcmp.s32 ge, q5, q5
0x25,0xfe,0x84,0x1f = vcmp.s32 lt, q2, q2
0x21,0xfe,0x03,0x1f = vcmp.s32 gt, q0, q1
0x2b,0xfe,0x89,0x1f = vcmp.s32 le, q5, q4
0x23,0xfe,0x89,0x0f = vcmp.u32 hi, q1, q4
0x23,0xfe,0x09,0x0f = vcmp.u32 cs, q1, q4
0x39,0xfe,0x6f,0x1f = vcmp.f16 gt, q4, zr
0x39,0xfe,0x4c,0x0f = vcmp.f16 eq, q4, r12
0x37,0xee,0xc0,0x0f = vcmp.f32 ne, q3, r0
0x03,0xfe,0x40,0x0f = vcmp.i8 eq, q1, r0
0x03,0xfe,0xe0,0x1f = vcmp.s8 le, q1, r0
0x03,0xfe,0x60,0x0f = vcmp.u8 cs, q1, r0
0x1b,0xfe,0x4a,0x0f = vcmp.i16 eq, q5, r10
0x23,0xfe,0x44,0x0f = vcmp.i32 eq, q1, r4
0x71,0xfe,0x4d,0x8f = vpste
0x01,0xfe,0x40,0x0f = vcmpt.i8 eq, q0, r0
0x11,0xfe,0xc0,0x0f = vcmpe.i16 ne, q0, r0
0xb4,0xee,0x60,0x09 = vcmp.f16 s0, s1
0xb4,0xee,0xe0,0x09 = vcmpe.f16 s0, s1
0x04,0xbf = itt eq
0xb4,0xee,0x60,0x0a = vcmpeq.f32 s0, s1
0xb4,0xee,0xe0,0x0a = vcmpeeq.f32 s0, s1
