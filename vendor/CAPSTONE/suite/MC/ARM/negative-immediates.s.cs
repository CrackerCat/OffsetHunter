# CS_ARCH_ARM, CS_MODE_THUMB, None
0x61,0xf1,0x01,0x10 = sbc r0, r1, #0x10001
0x61,0xf1,0x01,0x20 = sbc r0, r1, #0x1000100
0xa0,0xf1,0xfe,0x10 = sub.w r0, r0, #0xfe00fe
0xa1,0xf2,0xff,0x00 = subw r0, r1, #0xff
0xa1,0xf1,0xff,0x00 = sub.w r0, r1, #0xff
0x21,0xf0,0x01,0x20 = bic r0, r1, #0x1000100
0x01,0xf0,0x01,0x20 = and r0, r1, #0x1000100
0x61,0xf0,0x01,0x20 = orn r0, r1, #0x1000100
0x41,0xf0,0x01,0x20 = orr r0, r1, #0x1000100
