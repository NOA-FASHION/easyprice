; ModuleID = 'obj/Release/android/compressed_assemblies.armeabi-v7a.ll'
source_filename = "obj/Release/android/compressed_assemblies.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.CompressedAssemblyDescriptor = type {
	i32,; uint32_t uncompressed_file_size
	i8,; bool loaded
	i8*; uint8_t* data
}

%struct.CompressedAssemblies = type {
	i32,; uint32_t count
	%struct.CompressedAssemblyDescriptor*; CompressedAssemblyDescriptor* descriptors
}
@__CompressedAssemblyDescriptor_data_0 = internal global [17920 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_1 = internal global [28160 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_2 = internal global [32256 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_3 = internal global [78848 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_4 = internal global [162816 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_5 = internal global [13312 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_6 = internal global [166912 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_7 = internal global [207872 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_8 = internal global [196096 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_9 = internal global [4096 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_10 = internal global [5632 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_11 = internal global [24064 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_12 = internal global [300032 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_13 = internal global [13824 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_14 = internal global [13824 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_15 = internal global [15360 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_16 = internal global [456704 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_17 = internal global [2273280 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_18 = internal global [122880 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_19 = internal global [349696 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_20 = internal global [38400 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_21 = internal global [28672 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_22 = internal global [138240 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_23 = internal global [58368 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_24 = internal global [1073664 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_25 = internal global [742400 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_26 = internal global [26112 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_27 = internal global [51200 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_28 = internal global [218624 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_29 = internal global [36864 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_30 = internal global [5120 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_31 = internal global [419328 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_32 = internal global [55808 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_33 = internal global [89088 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_34 = internal global [64512 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_35 = internal global [1397760 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_36 = internal global [885248 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_37 = internal global [54272 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_38 = internal global [142848 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_39 = internal global [86016 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_40 = internal global [53248 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_41 = internal global [16896 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_42 = internal global [466432 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_43 = internal global [17920 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_44 = internal global [32256 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_45 = internal global [79360 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_46 = internal global [585728 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_47 = internal global [9216 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_48 = internal global [44032 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_49 = internal global [175104 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_50 = internal global [15872 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_51 = internal global [15360 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_52 = internal global [16384 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_53 = internal global [17408 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_54 = internal global [36864 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_55 = internal global [424448 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_56 = internal global [13312 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_57 = internal global [40448 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_58 = internal global [57856 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_59 = internal global [26112 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_60 = internal global [1208832 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_61 = internal global [936960 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_62 = internal global [250880 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_63 = internal global [103424 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_64 = internal global [258048 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_65 = internal global [769536 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_66 = internal global [2234368 x i8] zeroinitializer, align 1


; Compressed assembly data storage
@compressed_assembly_descriptors = internal global [67 x %struct.CompressedAssemblyDescriptor] [
	; 0
	%struct.CompressedAssemblyDescriptor {
		i32 17920, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([17920 x i8], [17920 x i8]* @__CompressedAssemblyDescriptor_data_0, i32 0, i32 0); data
	}, 
	; 1
	%struct.CompressedAssemblyDescriptor {
		i32 28160, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([28160 x i8], [28160 x i8]* @__CompressedAssemblyDescriptor_data_1, i32 0, i32 0); data
	}, 
	; 2
	%struct.CompressedAssemblyDescriptor {
		i32 32256, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([32256 x i8], [32256 x i8]* @__CompressedAssemblyDescriptor_data_2, i32 0, i32 0); data
	}, 
	; 3
	%struct.CompressedAssemblyDescriptor {
		i32 78848, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([78848 x i8], [78848 x i8]* @__CompressedAssemblyDescriptor_data_3, i32 0, i32 0); data
	}, 
	; 4
	%struct.CompressedAssemblyDescriptor {
		i32 162816, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([162816 x i8], [162816 x i8]* @__CompressedAssemblyDescriptor_data_4, i32 0, i32 0); data
	}, 
	; 5
	%struct.CompressedAssemblyDescriptor {
		i32 13312, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([13312 x i8], [13312 x i8]* @__CompressedAssemblyDescriptor_data_5, i32 0, i32 0); data
	}, 
	; 6
	%struct.CompressedAssemblyDescriptor {
		i32 166912, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([166912 x i8], [166912 x i8]* @__CompressedAssemblyDescriptor_data_6, i32 0, i32 0); data
	}, 
	; 7
	%struct.CompressedAssemblyDescriptor {
		i32 207872, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([207872 x i8], [207872 x i8]* @__CompressedAssemblyDescriptor_data_7, i32 0, i32 0); data
	}, 
	; 8
	%struct.CompressedAssemblyDescriptor {
		i32 196096, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([196096 x i8], [196096 x i8]* @__CompressedAssemblyDescriptor_data_8, i32 0, i32 0); data
	}, 
	; 9
	%struct.CompressedAssemblyDescriptor {
		i32 4096, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([4096 x i8], [4096 x i8]* @__CompressedAssemblyDescriptor_data_9, i32 0, i32 0); data
	}, 
	; 10
	%struct.CompressedAssemblyDescriptor {
		i32 5632, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([5632 x i8], [5632 x i8]* @__CompressedAssemblyDescriptor_data_10, i32 0, i32 0); data
	}, 
	; 11
	%struct.CompressedAssemblyDescriptor {
		i32 24064, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([24064 x i8], [24064 x i8]* @__CompressedAssemblyDescriptor_data_11, i32 0, i32 0); data
	}, 
	; 12
	%struct.CompressedAssemblyDescriptor {
		i32 300032, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([300032 x i8], [300032 x i8]* @__CompressedAssemblyDescriptor_data_12, i32 0, i32 0); data
	}, 
	; 13
	%struct.CompressedAssemblyDescriptor {
		i32 13824, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([13824 x i8], [13824 x i8]* @__CompressedAssemblyDescriptor_data_13, i32 0, i32 0); data
	}, 
	; 14
	%struct.CompressedAssemblyDescriptor {
		i32 13824, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([13824 x i8], [13824 x i8]* @__CompressedAssemblyDescriptor_data_14, i32 0, i32 0); data
	}, 
	; 15
	%struct.CompressedAssemblyDescriptor {
		i32 15360, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15360 x i8], [15360 x i8]* @__CompressedAssemblyDescriptor_data_15, i32 0, i32 0); data
	}, 
	; 16
	%struct.CompressedAssemblyDescriptor {
		i32 456704, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([456704 x i8], [456704 x i8]* @__CompressedAssemblyDescriptor_data_16, i32 0, i32 0); data
	}, 
	; 17
	%struct.CompressedAssemblyDescriptor {
		i32 2273280, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([2273280 x i8], [2273280 x i8]* @__CompressedAssemblyDescriptor_data_17, i32 0, i32 0); data
	}, 
	; 18
	%struct.CompressedAssemblyDescriptor {
		i32 122880, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([122880 x i8], [122880 x i8]* @__CompressedAssemblyDescriptor_data_18, i32 0, i32 0); data
	}, 
	; 19
	%struct.CompressedAssemblyDescriptor {
		i32 349696, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([349696 x i8], [349696 x i8]* @__CompressedAssemblyDescriptor_data_19, i32 0, i32 0); data
	}, 
	; 20
	%struct.CompressedAssemblyDescriptor {
		i32 38400, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([38400 x i8], [38400 x i8]* @__CompressedAssemblyDescriptor_data_20, i32 0, i32 0); data
	}, 
	; 21
	%struct.CompressedAssemblyDescriptor {
		i32 28672, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([28672 x i8], [28672 x i8]* @__CompressedAssemblyDescriptor_data_21, i32 0, i32 0); data
	}, 
	; 22
	%struct.CompressedAssemblyDescriptor {
		i32 138240, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([138240 x i8], [138240 x i8]* @__CompressedAssemblyDescriptor_data_22, i32 0, i32 0); data
	}, 
	; 23
	%struct.CompressedAssemblyDescriptor {
		i32 58368, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([58368 x i8], [58368 x i8]* @__CompressedAssemblyDescriptor_data_23, i32 0, i32 0); data
	}, 
	; 24
	%struct.CompressedAssemblyDescriptor {
		i32 1073664, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1073664 x i8], [1073664 x i8]* @__CompressedAssemblyDescriptor_data_24, i32 0, i32 0); data
	}, 
	; 25
	%struct.CompressedAssemblyDescriptor {
		i32 742400, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([742400 x i8], [742400 x i8]* @__CompressedAssemblyDescriptor_data_25, i32 0, i32 0); data
	}, 
	; 26
	%struct.CompressedAssemblyDescriptor {
		i32 26112, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([26112 x i8], [26112 x i8]* @__CompressedAssemblyDescriptor_data_26, i32 0, i32 0); data
	}, 
	; 27
	%struct.CompressedAssemblyDescriptor {
		i32 51200, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([51200 x i8], [51200 x i8]* @__CompressedAssemblyDescriptor_data_27, i32 0, i32 0); data
	}, 
	; 28
	%struct.CompressedAssemblyDescriptor {
		i32 218624, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([218624 x i8], [218624 x i8]* @__CompressedAssemblyDescriptor_data_28, i32 0, i32 0); data
	}, 
	; 29
	%struct.CompressedAssemblyDescriptor {
		i32 36864, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([36864 x i8], [36864 x i8]* @__CompressedAssemblyDescriptor_data_29, i32 0, i32 0); data
	}, 
	; 30
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([5120 x i8], [5120 x i8]* @__CompressedAssemblyDescriptor_data_30, i32 0, i32 0); data
	}, 
	; 31
	%struct.CompressedAssemblyDescriptor {
		i32 419328, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([419328 x i8], [419328 x i8]* @__CompressedAssemblyDescriptor_data_31, i32 0, i32 0); data
	}, 
	; 32
	%struct.CompressedAssemblyDescriptor {
		i32 55808, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([55808 x i8], [55808 x i8]* @__CompressedAssemblyDescriptor_data_32, i32 0, i32 0); data
	}, 
	; 33
	%struct.CompressedAssemblyDescriptor {
		i32 89088, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([89088 x i8], [89088 x i8]* @__CompressedAssemblyDescriptor_data_33, i32 0, i32 0); data
	}, 
	; 34
	%struct.CompressedAssemblyDescriptor {
		i32 64512, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([64512 x i8], [64512 x i8]* @__CompressedAssemblyDescriptor_data_34, i32 0, i32 0); data
	}, 
	; 35
	%struct.CompressedAssemblyDescriptor {
		i32 1397760, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1397760 x i8], [1397760 x i8]* @__CompressedAssemblyDescriptor_data_35, i32 0, i32 0); data
	}, 
	; 36
	%struct.CompressedAssemblyDescriptor {
		i32 885248, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([885248 x i8], [885248 x i8]* @__CompressedAssemblyDescriptor_data_36, i32 0, i32 0); data
	}, 
	; 37
	%struct.CompressedAssemblyDescriptor {
		i32 54272, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([54272 x i8], [54272 x i8]* @__CompressedAssemblyDescriptor_data_37, i32 0, i32 0); data
	}, 
	; 38
	%struct.CompressedAssemblyDescriptor {
		i32 142848, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([142848 x i8], [142848 x i8]* @__CompressedAssemblyDescriptor_data_38, i32 0, i32 0); data
	}, 
	; 39
	%struct.CompressedAssemblyDescriptor {
		i32 86016, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([86016 x i8], [86016 x i8]* @__CompressedAssemblyDescriptor_data_39, i32 0, i32 0); data
	}, 
	; 40
	%struct.CompressedAssemblyDescriptor {
		i32 53248, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([53248 x i8], [53248 x i8]* @__CompressedAssemblyDescriptor_data_40, i32 0, i32 0); data
	}, 
	; 41
	%struct.CompressedAssemblyDescriptor {
		i32 16896, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([16896 x i8], [16896 x i8]* @__CompressedAssemblyDescriptor_data_41, i32 0, i32 0); data
	}, 
	; 42
	%struct.CompressedAssemblyDescriptor {
		i32 466432, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([466432 x i8], [466432 x i8]* @__CompressedAssemblyDescriptor_data_42, i32 0, i32 0); data
	}, 
	; 43
	%struct.CompressedAssemblyDescriptor {
		i32 17920, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([17920 x i8], [17920 x i8]* @__CompressedAssemblyDescriptor_data_43, i32 0, i32 0); data
	}, 
	; 44
	%struct.CompressedAssemblyDescriptor {
		i32 32256, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([32256 x i8], [32256 x i8]* @__CompressedAssemblyDescriptor_data_44, i32 0, i32 0); data
	}, 
	; 45
	%struct.CompressedAssemblyDescriptor {
		i32 79360, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([79360 x i8], [79360 x i8]* @__CompressedAssemblyDescriptor_data_45, i32 0, i32 0); data
	}, 
	; 46
	%struct.CompressedAssemblyDescriptor {
		i32 585728, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([585728 x i8], [585728 x i8]* @__CompressedAssemblyDescriptor_data_46, i32 0, i32 0); data
	}, 
	; 47
	%struct.CompressedAssemblyDescriptor {
		i32 9216, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([9216 x i8], [9216 x i8]* @__CompressedAssemblyDescriptor_data_47, i32 0, i32 0); data
	}, 
	; 48
	%struct.CompressedAssemblyDescriptor {
		i32 44032, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([44032 x i8], [44032 x i8]* @__CompressedAssemblyDescriptor_data_48, i32 0, i32 0); data
	}, 
	; 49
	%struct.CompressedAssemblyDescriptor {
		i32 175104, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([175104 x i8], [175104 x i8]* @__CompressedAssemblyDescriptor_data_49, i32 0, i32 0); data
	}, 
	; 50
	%struct.CompressedAssemblyDescriptor {
		i32 15872, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15872 x i8], [15872 x i8]* @__CompressedAssemblyDescriptor_data_50, i32 0, i32 0); data
	}, 
	; 51
	%struct.CompressedAssemblyDescriptor {
		i32 15360, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15360 x i8], [15360 x i8]* @__CompressedAssemblyDescriptor_data_51, i32 0, i32 0); data
	}, 
	; 52
	%struct.CompressedAssemblyDescriptor {
		i32 16384, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([16384 x i8], [16384 x i8]* @__CompressedAssemblyDescriptor_data_52, i32 0, i32 0); data
	}, 
	; 53
	%struct.CompressedAssemblyDescriptor {
		i32 17408, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([17408 x i8], [17408 x i8]* @__CompressedAssemblyDescriptor_data_53, i32 0, i32 0); data
	}, 
	; 54
	%struct.CompressedAssemblyDescriptor {
		i32 36864, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([36864 x i8], [36864 x i8]* @__CompressedAssemblyDescriptor_data_54, i32 0, i32 0); data
	}, 
	; 55
	%struct.CompressedAssemblyDescriptor {
		i32 424448, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([424448 x i8], [424448 x i8]* @__CompressedAssemblyDescriptor_data_55, i32 0, i32 0); data
	}, 
	; 56
	%struct.CompressedAssemblyDescriptor {
		i32 13312, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([13312 x i8], [13312 x i8]* @__CompressedAssemblyDescriptor_data_56, i32 0, i32 0); data
	}, 
	; 57
	%struct.CompressedAssemblyDescriptor {
		i32 40448, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([40448 x i8], [40448 x i8]* @__CompressedAssemblyDescriptor_data_57, i32 0, i32 0); data
	}, 
	; 58
	%struct.CompressedAssemblyDescriptor {
		i32 57856, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([57856 x i8], [57856 x i8]* @__CompressedAssemblyDescriptor_data_58, i32 0, i32 0); data
	}, 
	; 59
	%struct.CompressedAssemblyDescriptor {
		i32 26112, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([26112 x i8], [26112 x i8]* @__CompressedAssemblyDescriptor_data_59, i32 0, i32 0); data
	}, 
	; 60
	%struct.CompressedAssemblyDescriptor {
		i32 1208832, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1208832 x i8], [1208832 x i8]* @__CompressedAssemblyDescriptor_data_60, i32 0, i32 0); data
	}, 
	; 61
	%struct.CompressedAssemblyDescriptor {
		i32 936960, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([936960 x i8], [936960 x i8]* @__CompressedAssemblyDescriptor_data_61, i32 0, i32 0); data
	}, 
	; 62
	%struct.CompressedAssemblyDescriptor {
		i32 250880, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([250880 x i8], [250880 x i8]* @__CompressedAssemblyDescriptor_data_62, i32 0, i32 0); data
	}, 
	; 63
	%struct.CompressedAssemblyDescriptor {
		i32 103424, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([103424 x i8], [103424 x i8]* @__CompressedAssemblyDescriptor_data_63, i32 0, i32 0); data
	}, 
	; 64
	%struct.CompressedAssemblyDescriptor {
		i32 258048, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([258048 x i8], [258048 x i8]* @__CompressedAssemblyDescriptor_data_64, i32 0, i32 0); data
	}, 
	; 65
	%struct.CompressedAssemblyDescriptor {
		i32 769536, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([769536 x i8], [769536 x i8]* @__CompressedAssemblyDescriptor_data_65, i32 0, i32 0); data
	}, 
	; 66
	%struct.CompressedAssemblyDescriptor {
		i32 2234368, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([2234368 x i8], [2234368 x i8]* @__CompressedAssemblyDescriptor_data_66, i32 0, i32 0); data
	}
], align 4; end of 'compressed_assembly_descriptors' array


; compressed_assemblies
@compressed_assemblies = local_unnamed_addr global %struct.CompressedAssemblies {
	i32 67, ; count
	%struct.CompressedAssemblyDescriptor* getelementptr inbounds ([67 x %struct.CompressedAssemblyDescriptor], [67 x %struct.CompressedAssemblyDescriptor]* @compressed_assembly_descriptors, i32 0, i32 0); descriptors
}, align 4


!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-3 @ 030cd63c06d95a6b0d0f563fe9b9d537f84cb84b"}
