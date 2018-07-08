import React from "react";
import { Field } from "redux-form";

export interface IProps {
  handleSubmit: (input: object) => any;
}

const Customer = ({
  handleSubmit,
}: IProps) => (
  <form onSubmit={handleSubmit}>
    <Field
      name="accountNumber"
      id="accountNumber"
      placeholder="Account Number"
      component="input"
    />

    <button>Get Rewards</button>
  </form>
);

export default Customer;
