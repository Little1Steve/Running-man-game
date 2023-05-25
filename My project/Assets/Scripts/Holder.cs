using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{
    public static double Speed = 1d;
    public static double SpeedPerTime = 0.2d;
    public static double SpeedPerClick = 0.1d;
    public static double SpeedUpgradeCost = 10d;
    public static double SpeedUpgradeAmount = 0.1d;
    public static double SpeedUpgradeCostMultiplier = 1.1d;
    public static decimal SpeedIncreaseDelayTime = 10M;
    public static double SpeedUpgradeClickCost = 10d;
    public static double SpeedUpgradeClickAmount = 0.05d;
    public static double TickSpeedUpgradeCost = 10d;
    public static decimal TickSpeedUpgradeAmount = 43M/44M;
    public static double BigUpgradeCost = 10d;
    public static double BigUpgradeAmount = 2d;
    public static double BigUpgradeCostMultiplier = 4d;
    public static float CameraMoveSpeed = 5f;
    public static float CameraMoveSpeedIncrease = 1f;
    public static float CoinMoveSpeed = 5f;
    public static double Coins = 0d;
    public static double CoinsIncrease = 1d; 
    public static double PassiveSpeedDecrease = 1f;
    public static double SpeedDecreaseDelayTime = 10f;
    public static double CoinsPerCoin = 1d;
    public static double CoinsPerCoinUpgradeAmount = 0.5d;
    public static double CoinsPerCoinUpgradeCost = 10d;
    public static double BaseTimeBetweenCoins = 5d;
}

public class Layout : MonoBehaviour
{
    public static float TextPaddingSize = 2f;


}