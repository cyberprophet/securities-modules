﻿namespace ShareInvest.Utilities.Kiwoom;

public enum Revise
{
    유상증자 = 1,
    무상증자 = 2,
    배당락 = 4,
    액면분할 = 8,
    액면병합 = 16,
    기업합병 = 32,
    감자 = 64,
    권리락 = 256
}
public enum RealType
{
    주식시세 = 19,
    주식체결 = 25,
    주식우선호가 = 2,
    주식호가잔량 = 103,
    주식시간외호가 = 5,
    주식당일거래원 = 57,
    ETF_NAV = 15 + 'e',
    ELW_지표 = 6 + 'e',
    ELW_이론가 = 10 + 'e',
    주식예상체결 = 7,
    주식종목정보 = 11,
    선물옵션우선호가 = 3 + 'f',
    선물시세 = 32 + 'f',
    선물호가잔량 = 60 + 'f',
    선물이론가 = 10 + 'f',
    옵션시세 = 42 + 'o',
    옵션호가잔량 = 60 + 'o',
    옵션이론가 = 15 + 'o',
    업종지수 = 12,
    업종등락 = 14,
    장시작시간 = 3,
    VI발동_해제 = 19 + 'v',
    종목프로그램매매 = 17
}
public enum OrderState
{
    접수,
    체결,
    취소
}
public enum OrderStatus
{
    매도 = 1,
    매수 = 2
}