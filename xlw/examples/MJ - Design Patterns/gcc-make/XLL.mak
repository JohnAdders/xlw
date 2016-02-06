#Describes the xll 
LIBRARY = Payoff
LIBTYPE=SHARE
LIBPREFIX=
EXT_SHARE=xll

#Describes the Compiler details
INCLUDE_DIR =../common_source 
CXXFLAGS = 

#The source
SRC_DIR=../common_source
LIBSRC = PayOff.cpp \
		 PayOffConcrete.cpp \
		 PayOffRegistration.cpp \
		 Test.cpp \
		 xlwTest.cpp  \
		 xlwLibrary.cpp
		
MAKEDIR = $(XLW)/xlw/make
include $(MAKEDIR)/make.rules
include $(MAKEDIR)/make.targets