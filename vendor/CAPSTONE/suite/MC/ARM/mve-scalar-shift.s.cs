# CS_ARCH_ARM, CS_MODE_THUMB+CS_MODE_V8+CS_MODE_MCLASS, None
0x50,0xea,0xef,0x51 = asrl r0, r1, #0x17
0x5e,0xea,0xef,0x61 = asrl lr, r1, #0x1b
0x50,0xea,0x2d,0x41 = asrl r0, r1, r4
0x52,0xea,0x22,0x9e = cinc lr, r2, lo
0x57,0xea,0x47,0x9e = cinc lr, r7, pl
0x5c,0xea,0x3c,0xae = cinv lr, r12, hs
0x5a,0xea,0x3a,0xbe = cneg lr, r10, hs
0x59,0xea,0x7b,0x89 = csel r9, r9, r11, vc
0x5f,0xea,0x1f,0x9e = cset lr, eq
0x5f,0xea,0x3f,0xae = csetm lr, hs
0x5a,0xea,0xd7,0x9e = csinc lr, r10, r7, le
0x55,0xea,0x2f,0xae = csinv lr, r5, zr, hs
0x52,0xea,0x42,0xae = cinv lr, r2, pl
0x51,0xea,0x7b,0xbe = csneg lr, r1, r11, vc
0x5e,0xea,0xcf,0x21 = lsll lr, r1, #0xb
0x5e,0xea,0x0d,0x41 = lsll lr, r1, r4
0x5e,0xea,0x1f,0x31 = lsrl lr, r1, #0xc
0x5e,0xea,0x2d,0xcf = sqrshr lr, r12
0x5b,0xea,0x2d,0xcf = sqrshr r11, r12
0x5f,0xea,0x2d,0x83 = sqrshrl lr, r3, #0x40, r8
0x5e,0xea,0x7f,0x4f = sqshl lr, #0x11
0x5f,0xea,0x3f,0x7b = sqshll lr, r11, #0x1c
0x5e,0xea,0xef,0x2f = srshr lr, #0xb
0x5f,0xea,0xef,0x5b = srshrl lr, r11, #0x17
0x5e,0xea,0x0d,0x1f = uqrshl lr, r1
0x5f,0xea,0x8d,0x41 = uqrshll lr, r1, #0x30, r4
0x50,0xea,0x4f,0x0f = uqshl r0, #1
0x5f,0xea,0xcf,0x17 = uqshll lr, r7, #7
0x50,0xea,0x9f,0x2f = urshr r0, #0xa
0x51,0xea,0x5f,0x79 = urshrl r0, r9, #0x1d
