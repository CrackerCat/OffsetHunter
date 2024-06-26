/* Capstone Disassembly Engine, http://www.capstone-engine.org */
/* By Nguyen Anh Quynh <aquynh@gmail.com>, 2013-2022, */
/*    Rot127 <unisono@quyllur.org> 2022-2023 */
/* Automatically generated file by Capstone's LLVM TableGen Disassembler Backend. */

/* LLVM-commit: 464bda7750a3ba9e23823fc707d7e7b6fc38438d */
/* LLVM-tag: llvmorg-16.0.2-5-g464bda7750a3 */

/* Do not edit. */

/* Capstone's LLVM TableGen Backends: */
/* https://github.com/capstone-engine/llvm-capstone */

#ifdef GET_SUBTARGETINFO_ENUM
#undef GET_SUBTARGETINFO_ENUM

enum {
  PPC_AIXOS = 0,
  PPC_DeprecatedDST = 1,
  PPC_Directive32 = 2,
  PPC_Directive64 = 3,
  PPC_Directive440 = 4,
  PPC_Directive601 = 5,
  PPC_Directive602 = 6,
  PPC_Directive603 = 7,
  PPC_Directive604 = 8,
  PPC_Directive620 = 9,
  PPC_Directive750 = 10,
  PPC_Directive970 = 11,
  PPC_Directive7400 = 12,
  PPC_DirectiveA2 = 13,
  PPC_DirectiveE500 = 14,
  PPC_DirectiveE500mc = 15,
  PPC_DirectiveE5500 = 16,
  PPC_DirectivePwr3 = 17,
  PPC_DirectivePwr4 = 18,
  PPC_DirectivePwr5 = 19,
  PPC_DirectivePwr5x = 20,
  PPC_DirectivePwr6 = 21,
  PPC_DirectivePwr6x = 22,
  PPC_DirectivePwr7 = 23,
  PPC_DirectivePwr8 = 24,
  PPC_DirectivePwr9 = 25,
  PPC_DirectivePwr10 = 26,
  PPC_DirectivePwrFuture = 27,
  PPC_Feature64Bit = 28,
  PPC_Feature64BitRegs = 29,
  PPC_FeatureAddLogicalFusion = 30,
  PPC_FeatureAddiLoadFusion = 31,
  PPC_FeatureAddisLoadFusion = 32,
  PPC_FeatureAltivec = 33,
  PPC_FeatureArithAddFusion = 34,
  PPC_FeatureBPERMD = 35,
  PPC_FeatureBack2BackFusion = 36,
  PPC_FeatureBookE = 37,
  PPC_FeatureCMPB = 38,
  PPC_FeatureCRBits = 39,
  PPC_FeatureCompareFusion = 40,
  PPC_FeatureDirectMove = 41,
  PPC_FeatureE500 = 42,
  PPC_FeatureEFPU2 = 43,
  PPC_FeatureExtDiv = 44,
  PPC_FeatureFCPSGN = 45,
  PPC_FeatureFPCVT = 46,
  PPC_FeatureFPRND = 47,
  PPC_FeatureFPU = 48,
  PPC_FeatureFRE = 49,
  PPC_FeatureFRES = 50,
  PPC_FeatureFRSQRTE = 51,
  PPC_FeatureFRSQRTES = 52,
  PPC_FeatureFSqrt = 53,
  PPC_FeatureFastMFLR = 54,
  PPC_FeatureFloat128 = 55,
  PPC_FeatureFusion = 56,
  PPC_FeatureHTM = 57,
  PPC_FeatureHardFloat = 58,
  PPC_FeatureICBT = 59,
  PPC_FeatureISA2_06 = 60,
  PPC_FeatureISA2_07 = 61,
  PPC_FeatureISA3_0 = 62,
  PPC_FeatureISA3_1 = 63,
  PPC_FeatureISAFuture = 64,
  PPC_FeatureISEL = 65,
  PPC_FeatureInvariantFunctionDescriptors = 66,
  PPC_FeatureLDBRX = 67,
  PPC_FeatureLFIWAX = 68,
  PPC_FeatureLogicalAddFusion = 69,
  PPC_FeatureLogicalFusion = 70,
  PPC_FeatureLongCall = 71,
  PPC_FeatureMFOCRF = 72,
  PPC_FeatureMFTB = 73,
  PPC_FeatureMMA = 74,
  PPC_FeatureMSYNC = 75,
  PPC_FeatureModernAIXAs = 76,
  PPC_FeatureP8Altivec = 77,
  PPC_FeatureP8Crypto = 78,
  PPC_FeatureP8Vector = 79,
  PPC_FeatureP9Altivec = 80,
  PPC_FeatureP9Vector = 81,
  PPC_FeatureP10Vector = 82,
  PPC_FeaturePCRelativeMemops = 83,
  PPC_FeaturePOPCNTD = 84,
  PPC_FeaturePPC4xx = 85,
  PPC_FeaturePPC6xx = 86,
  PPC_FeaturePPCPostRASched = 87,
  PPC_FeaturePPCPreRASched = 88,
  PPC_FeaturePS = 89,
  PPC_FeaturePairedVectorMemops = 90,
  PPC_FeaturePartwordAtomic = 91,
  PPC_FeaturePredictableSelectIsExpensive = 92,
  PPC_FeaturePrefixInstrs = 93,
  PPC_FeaturePrivileged = 94,
  PPC_FeatureQPX = 95,
  PPC_FeatureQuadwordAtomic = 96,
  PPC_FeatureROPProtect = 97,
  PPC_FeatureRecipPrec = 98,
  PPC_FeatureSPE = 99,
  PPC_FeatureSTFIWX = 100,
  PPC_FeatureSecurePlt = 101,
  PPC_FeatureSha3Fusion = 102,
  PPC_FeatureSlowPOPCNTD = 103,
  PPC_FeatureStoreFusion = 104,
  PPC_FeatureTwoConstNR = 105,
  PPC_FeatureUnalignedFloats = 106,
  PPC_FeatureVSX = 107,
  PPC_FeatureVectorsUseTwoUnits = 108,
  PPC_FeatureWideImmFusion = 109,
  PPC_FeatureZeroMoveFusion = 110,
  PPC_NumSubtargetFeatures = 111
};
#endif // GET_SUBTARGETINFO_ENUM



