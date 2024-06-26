# CS_ARCH_ARM, CS_MODE_THUMB, None
0x41,0xef,0xb0,0x04 = vqshl.s8 d16, d16, d17
0x51,0xef,0xb0,0x04 = vqshl.s16 d16, d16, d17
0x61,0xef,0xb0,0x04 = vqshl.s32 d16, d16, d17
0x71,0xef,0xb0,0x04 = vqshl.s64 d16, d16, d17
0x41,0xff,0xb0,0x04 = vqshl.u8 d16, d16, d17
0x51,0xff,0xb0,0x04 = vqshl.u16 d16, d16, d17
0x61,0xff,0xb0,0x04 = vqshl.u32 d16, d16, d17
0x71,0xff,0xb0,0x04 = vqshl.u64 d16, d16, d17
0x42,0xef,0xf0,0x04 = vqshl.s8 q8, q8, q9
0x52,0xef,0xf0,0x04 = vqshl.s16 q8, q8, q9
0x62,0xef,0xf0,0x04 = vqshl.s32 q8, q8, q9
0x72,0xef,0xf0,0x04 = vqshl.s64 q8, q8, q9
0x42,0xff,0xf0,0x04 = vqshl.u8 q8, q8, q9
0x52,0xff,0xf0,0x04 = vqshl.u16 q8, q8, q9
0x62,0xff,0xf0,0x04 = vqshl.u32 q8, q8, q9
0x72,0xff,0xf0,0x04 = vqshl.u64 q8, q8, q9
0xcf,0xef,0x30,0x07 = vqshl.s8 d16, d16, #7
0xdf,0xef,0x30,0x07 = vqshl.s16 d16, d16, #0xf
0xff,0xef,0x30,0x07 = vqshl.s32 d16, d16, #0x1f
0xff,0xef,0xb0,0x07 = vqshl.s64 d16, d16, #0x3f
0xcf,0xff,0x30,0x07 = vqshl.u8 d16, d16, #7
0xdf,0xff,0x30,0x07 = vqshl.u16 d16, d16, #0xf
0xff,0xff,0x30,0x07 = vqshl.u32 d16, d16, #0x1f
0xff,0xff,0xb0,0x07 = vqshl.u64 d16, d16, #0x3f
0xcf,0xff,0x30,0x06 = vqshlu.s8 d16, d16, #7
0xdf,0xff,0x30,0x06 = vqshlu.s16 d16, d16, #0xf
0xff,0xff,0x30,0x06 = vqshlu.s32 d16, d16, #0x1f
0xff,0xff,0xb0,0x06 = vqshlu.s64 d16, d16, #0x3f
0xcf,0xef,0x70,0x07 = vqshl.s8 q8, q8, #7
0xdf,0xef,0x70,0x07 = vqshl.s16 q8, q8, #0xf
0xff,0xef,0x70,0x07 = vqshl.s32 q8, q8, #0x1f
0xff,0xef,0xf0,0x07 = vqshl.s64 q8, q8, #0x3f
0xcf,0xff,0x70,0x07 = vqshl.u8 q8, q8, #7
0xdf,0xff,0x70,0x07 = vqshl.u16 q8, q8, #0xf
0xff,0xff,0x70,0x07 = vqshl.u32 q8, q8, #0x1f
0xff,0xff,0xf0,0x07 = vqshl.u64 q8, q8, #0x3f
0xcf,0xff,0x70,0x06 = vqshlu.s8 q8, q8, #7
0xdf,0xff,0x70,0x06 = vqshlu.s16 q8, q8, #0xf
0xff,0xff,0x70,0x06 = vqshlu.s32 q8, q8, #0x1f
0xff,0xff,0xf0,0x06 = vqshlu.s64 q8, q8, #0x3f
0x41,0xef,0xb0,0x05 = vqrshl.s8 d16, d16, d17
0x51,0xef,0xb0,0x05 = vqrshl.s16 d16, d16, d17
0x61,0xef,0xb0,0x05 = vqrshl.s32 d16, d16, d17
0x71,0xef,0xb0,0x05 = vqrshl.s64 d16, d16, d17
0x41,0xff,0xb0,0x05 = vqrshl.u8 d16, d16, d17
0x51,0xff,0xb0,0x05 = vqrshl.u16 d16, d16, d17
0x61,0xff,0xb0,0x05 = vqrshl.u32 d16, d16, d17
0x71,0xff,0xb0,0x05 = vqrshl.u64 d16, d16, d17
0x42,0xef,0xf0,0x05 = vqrshl.s8 q8, q8, q9
0x52,0xef,0xf0,0x05 = vqrshl.s16 q8, q8, q9
0x62,0xef,0xf0,0x05 = vqrshl.s32 q8, q8, q9
0x72,0xef,0xf0,0x05 = vqrshl.s64 q8, q8, q9
0x42,0xff,0xf0,0x05 = vqrshl.u8 q8, q8, q9
0x52,0xff,0xf0,0x05 = vqrshl.u16 q8, q8, q9
0x62,0xff,0xf0,0x05 = vqrshl.u32 q8, q8, q9
0x72,0xff,0xf0,0x05 = vqrshl.u64 q8, q8, q9
0xc8,0xef,0x30,0x09 = vqshrn.s16 d16, q8, #8
0xd0,0xef,0x30,0x09 = vqshrn.s32 d16, q8, #0x10
0xe0,0xef,0x30,0x09 = vqshrn.s64 d16, q8, #0x20
0xc8,0xff,0x30,0x09 = vqshrn.u16 d16, q8, #8
0xd0,0xff,0x30,0x09 = vqshrn.u32 d16, q8, #0x10
0xe0,0xff,0x30,0x09 = vqshrn.u64 d16, q8, #0x20
0xc8,0xff,0x30,0x08 = vqshrun.s16 d16, q8, #8
0xd0,0xff,0x30,0x08 = vqshrun.s32 d16, q8, #0x10
0xe0,0xff,0x30,0x08 = vqshrun.s64 d16, q8, #0x20
0xc8,0xef,0x70,0x09 = vqrshrn.s16 d16, q8, #8
0xd0,0xef,0x70,0x09 = vqrshrn.s32 d16, q8, #0x10
0xe0,0xef,0x70,0x09 = vqrshrn.s64 d16, q8, #0x20
0xc8,0xff,0x70,0x09 = vqrshrn.u16 d16, q8, #8
0xd0,0xff,0x70,0x09 = vqrshrn.u32 d16, q8, #0x10
0xe0,0xff,0x70,0x09 = vqrshrn.u64 d16, q8, #0x20
0xc8,0xff,0x70,0x08 = vqrshrun.s16 d16, q8, #8
0xd0,0xff,0x70,0x08 = vqrshrun.s32 d16, q8, #0x10
0xe0,0xff,0x70,0x08 = vqrshrun.s64 d16, q8, #0x20
