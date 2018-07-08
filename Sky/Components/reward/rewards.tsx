import React from "react";

export interface IProps {
  rewards: Array<{
    rewardType: string
  }>;
}

const Rewards = ({
  rewards,
}: IProps) => rewards.length ? (
  <div>
    rewards: {rewards.map((reward) => reward.rewardType)}
  </div>)
  : (
    <div>
      No rewards
    </div>
);

export default Rewards;
