﻿namespace ShareInvest.Data;

/// <summary>market event code used by Kiwoom Securities</summary>
public enum MarketEvent
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
public static class Market
{
    /// <summary>각 함수에서 리턴값으로 성공여부와 오류메세지를 반환합니다.</summary>
    public static Dictionary<int, string> Error
    {
        get => new()
        {
            {
                0, "정상처리"
            },
            {
                -1, "미접속상태"
            },
            {
                -10, "실패"
            },
            {
                -11, "조건번호 없음"
            },
            {
                -12, "조건번호와 조건식 불일치"
            },
            {
                -13, "조건검색 조회요청 초과"
            },
            {
                -22, "전문 처리 실패"
            },
            {
                -0x64, "사용자정보교환 실패"
            },
            {
                -101, "서버 접속 실패"
            },
            {
                -102, "버전처리 실패"
            },
            {
                -103, "개인방화벽 실패"
            },
            {
                -104, "메모리 보호실패"
            },
            {
                -105, "함수입력값 오류"
            },
            {
                -0x6A, "통신연결 종료"
            },
            {
                -107, "보안모듈 오류"
            },
            {
                -108, "공인인증 로그인 필요"
            },
            {
                -0xC8, "시세조회 과부하"
            },
            {
                -201, "전문작성 초기화 실패"
            },
            {
                -0xCA, "전문작성 입력값 오류"
            },
            {
                -203, "데이터 없음"
            },
            {
                -204, "조회가능한 종목수 초과.(한번에 조회 가능한 종목개수는 최대 100종목)"
            },
            {
                -205, "데이터 수신 실패"
            },
            {
                -206, "조회가능한 FID수 초과.(한번에 조회 가능한 FID개수는 최대 100개)"
            },
            {
                -207, "실시간 해제오류"
            },
            {
                -209, "시세조회 제한"
            },
            {
                -0xD3, "시세조회 과부하"
            },
            {
                -300, "입력값 오류"
            },
            {
                -301, "계좌비밀번호 없음"
            },
            {
                -302, "타인계좌 사용오류"
            },
            {
                -303, "주문가격이 주문착오 금액기준 초과."
            },
            {
                -304, "주문가격이 주문착오 금액기준 초과."
            },
            {
                -305, "주문수량이 총발행주수의 1% 초과오류"
            },
            {
                -306, "주문수량은 총발행주수의 3% 초과오류"
            },
            {
                -307, "주문전송 실패"
            },
            {
                -308, "주문전송 과부하"
            },
            {
                -309, "주문수량 300계약 초과"
            },
            {
                -310, "주문수량 500계약 초과"
            },
            {
                -311, "주문전송제한 과부하"
            },
            {
                -340, "계좌정보 없음"
            },
            {
                -500, "종목코드 없음"
            }
        };
    }
    /// <summary>market classification code used by Kiwoom Securities</summary>
    public static Dictionary<string, string> ClassificationCodes
    {
        get => new()
        {
            {
                "코스피", "0"
            },
            {
                "코스닥", "10"
            },
            {
                "ELW", "3"
            },
            {
                "ETF", "8"
            },
            {
                "KONEX", "50"
            },
            {
                "뮤추얼펀드", "4"
            },
            {
                "신주인수권", "5"
            },
            {
                "리츠", "6"
            },
            {
                "하이얼펀드", "9"
            },
            {
                "K-OTC", "30"
            }
        };
    }
    /// <summary>RealType : 장시작시간</summary>
    /// <param name="gubun">[215] = 장운영구분</param>
    /// <returns><see cref="MarketOperation"/></returns>
    public static MarketOperation GetOperation(string? gubun)
    {
        if (gubun?.Length == 1)
        {
            var index = char.IsDigit(gubun[0]) ? Convert.ToInt32(gubun) : Convert.ToChar(gubun);

            if (Enum.IsDefined(typeof(MarketOperation), index))
            {
                return (MarketOperation)index;
            }
        }
        return MarketOperation.장종료_시간외종료;
    }
}