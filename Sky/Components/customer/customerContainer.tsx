import { compose, withHandlers } from "recompose";
import { reduxForm } from "redux-form";

import { Route } from "../types";
import Customer, { IProps } from "./customer";

interface IGetRewardsOnClickInput {
  accountNumber: number;
}

const handlers = {
  onSubmit: ({ router }: Route) => ({ accountNumber }: IGetRewardsOnClickInput) => {
    router.push(`/rewards?accountNumber=${accountNumber}`);
  },
};

const CustomerContainer = compose<IProps, IProps>(
  withHandlers(handlers),
  reduxForm({
    form: "customer",
  }),
)(Customer);

export const routeConfig = {
  Component: CustomerContainer,
};

export default CustomerContainer;
