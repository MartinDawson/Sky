import React from "react";
import { graphql } from "react-relay";
import { compose } from "recompose";
import { reduxForm } from "redux-form";

import { Match, Route } from "../types";
import Rewards, { IProps } from "./rewards";

const code = "INVALID_ACCOUNT_NUMBER";

const query = graphql`
  query rewardsContainerQuery(
    $accountNumber: Int!
  ) {
    rewards(
      accountNumber: $accountNumber
    ) {
      rewardType
    }
  }
`;

const RewardsContainer = compose<IProps, IProps>(
  reduxForm({
    form: "rewards",
  }),
)(Rewards);

export const routeConfig = {
  Component: RewardsContainer,
  prepareVariables: (_: Route, { location }: Match) => ({
    accountNumber: location.query.accountNumber,
  }),
  query,
  render: (route: Route): JSX.Element => {
    if (route.error) {
      if (route.error.code === code) {
        return <div>Invalid account number</div>;
      }
    }

    if (route.props) {
      return <RewardsContainer rewards={route.props.rewards} />;
    }

    return null;
  }
};

export default RewardsContainer;
