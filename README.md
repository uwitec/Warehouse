# Warehouse
#简单条码库存管理系统
#系统目标：
#通过条码管理库存，提高成品出入库管理的工作效率、准确性、实时性。当有退换货时可迅速查找出问题货源。可实时生成各种统计报表。
#开发环境：
#C# + WINFORM + VS2008 + SqlServer2005 + TSC条码机 + 无线扫码枪
#系统流程：
#1、录入新成品，系统根据新成品规格自动生成流水条码编号。
#2、调用TSC条码打印机打印流水条码编号。
#3、把条码贴到对应规格的成品上。
#4、出货时，打开出货界面，用无线条码枪扫描要出货的成品，系统自己统计出货成品，并生成出货单报表。
#5、可实时查看销售走势、库存数量。


