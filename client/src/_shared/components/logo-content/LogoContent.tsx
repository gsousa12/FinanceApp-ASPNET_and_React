import { PiggyBank } from "lucide-react";

type LogoContentProps = {
  hasIcon: boolean;
};

const LogoContent = ({ hasIcon }: LogoContentProps) => {
  return (
    <div className="flex gap-5">
      {hasIcon && <PiggyBank className="w-[80px] h-[80px]" />}
      <span className="self-center text-4xl text-green-600 font-bold">
        Finance App
      </span>
    </div>
  );
};

export default LogoContent;
