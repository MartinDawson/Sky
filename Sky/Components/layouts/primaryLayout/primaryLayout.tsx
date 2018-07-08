import React from "react";

interface IProps {
  children: React.ReactNode;
}

const PrimaryLayout = ({
  children,
}: IProps) => (
  <div>
    {children}
  </div>
);

export default PrimaryLayout;
