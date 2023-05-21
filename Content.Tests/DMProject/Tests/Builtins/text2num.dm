/proc/RunTest()
	ASSERT(text2num("12") == 12)
	ASSERT(text2num(null) == null)
	ASSERT(text2num("") == null)
	ASSERT(text2num("0") == 0)
	ASSERT(text2num("1.2344") == 1.2344)
	ASSERT(text2num("0.0") == 0)
	ASSERT(text2num("Z", 36) == 35)
	ASSERT(text2num("A", 16) == 10)	
